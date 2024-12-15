using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class Form_update : Form
    {
        private Form1 f;
        private int index;
        private DataTable table;
        private string connectionString;
        public Form_update(int i, Form1 f)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = i;
            this.f = f;
        }

        public static List<string> GetPrimaryKeyColumns(NpgsqlConnection connection, string tableName)
        {
            List<string> result = new List<string>();
            NpgsqlCommand command = connection.CreateCommand();
            string[] restrictions = new string[] { null, null, tableName };
            DataTable table = connection.GetSchema("IndexColumns", restrictions);

            if (string.IsNullOrEmpty(tableName))
                throw new Exception("Table name must be set.");

            foreach (DataRow row in table.Rows)
            {
                result.Add(row["column_name"].ToString());
            }

            return result;
        }

        private string tablename;
        private List<string> pk;
        private NpgsqlConnection connection;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Host = localhost; Database = hotel; User Id = postgres; Password = Bumclood!2456; ";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
            tablename = comboBox1.SelectedItem.ToString();
            pk = GetPrimaryKeyColumns(connection, tablename);
            textBox1.Text = pk[0];
            if (pk.Count > 1)
            {
                textBox_pk2.ReadOnly = false;
                textBox2.Text = pk[1];
            }
            else
            {
                textBox_pk2.ReadOnly = true;
                textBox2.Text = "No second primary key";
            }
            TextBox[] coltextbox = { textBox_col1, textBox_col2, textBox_col3, textBox_col4, textBox_col5, textBox_col6 };
            string[] restrictions = new string[4] { null, null, tablename, null };
            table = connection.GetSchema("Columns", restrictions);

            var columnList = connection.GetSchema("Columns", restrictions).AsEnumerable().Select(s => s.Field<String>("Column_Name")).ToList();


            index = 0;

            for (int i = 0; i < 6; i++)
                coltextbox[i].Text = "";
            foreach (string column in columnList)
            {
                coltextbox[index].Text = column;
                index++;
            }

            TextBox[] valtextbox = { textBox_val1, textBox_val2, textBox_val3, textBox_val4, textBox_val5, textBox_val6 };
            for (int i = 0; i < 6; i++)
                if (i >= index) valtextbox[i].ReadOnly = true;
                else valtextbox[i].ReadOnly = false;
            connection.Close();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            TextBox[] valtextbox = { textBox_val1, textBox_val2, textBox_val3, textBox_val4, textBox_val5, textBox_val6 };
            string cmd;
            string formattedstring = "";
            connection.Open();
            string[] restrictions = new string[4] { null, null, tablename, null };
            var columnList = connection.GetSchema("Columns", restrictions).AsEnumerable().Select(s => s.Field<String>("Column_Name")).ToList();

            for (int i = 0; i < 6; i++)
            {
                if (valtextbox[i].Text != "")
                {
                    if (formattedstring == "")
                    {
                        formattedstring = columnList[i] + "=" + valtextbox[i].Text;
                    }
                    else
                    {
                        formattedstring += ", " + columnList[i] + "=" + valtextbox[i].Text;
                    }
                }
            }
            if (pk.Count == 1) cmd = String.Format("UPDATE {0} SET {1} WHERE {2} = {3}", tablename, formattedstring, pk[0], textBox_pk1.Text);
            else cmd = String.Format("UPDATE {0} SET {1} WHERE {2} = {3} AND {4} = {5}", tablename, formattedstring, pk[0], textBox_pk1.Text, pk[1], textBox_pk2.Text);
            new NpgsqlCommand(cmd, connection).ExecuteReader();
            connection.Close();
            f.UpdateGrid();
        }
    }
}
