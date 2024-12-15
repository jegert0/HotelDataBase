using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class Form_insert : Form
    {
        private Form1 f;
        private string tablename;
        private NpgsqlConnection connection;
        private int index;
        private DataTable table;

        public Form_insert(int i, Form1 f)
        {
            InitializeComponent();
            comboBox1.SelectedIndex = i;
            this.f = f;
            //connectionString = con;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = "Host = localhost; Database = hotel; User Id = postgres; Password = Bumclood!2456; ";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
            tablename = comboBox1.SelectedItem.ToString();
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

        private void button_insert_Click(object sender, EventArgs e)
        {
            TextBox[] coltextbox = { textBox_col1, textBox_col2, textBox_col3, textBox_col4, textBox_col5, textBox_col6 };
            TextBox[] valtextbox = { textBox_val1, textBox_val2, textBox_val3, textBox_val4, textBox_val5, textBox_val6 };
            string cmd;
            string formattedcol = "";
            string formattedval = "";
            connection.Open();
            string[] restrictions = new string[4] { null, null, tablename, null };
            var columnList = connection.GetSchema("Columns", restrictions).AsEnumerable().Select(s => s.Field<String>("Column_Name")).ToList();

            for (int i = 0; i < 6; i++)
            {
                if (valtextbox[i].Text != "")
                {
                    if (formattedcol == "")
                    {
                        formattedcol = columnList[i];
                    }
                    else
                    {
                        formattedcol += ", " + columnList[i];
                    }
                }

                if (coltextbox[i].Text != "")
                {
                    if (formattedval == "")
                    {
                        formattedval = valtextbox[i].Text;
                    }
                    else 
                    {
                        formattedval += ", " + valtextbox[i].Text;
                    }
                }
            }
            cmd = String.Format("INSERT INTO {0} ({1}) VALUES ({2})", tablename, formattedcol, formattedval);
            new NpgsqlCommand(cmd, connection).ExecuteReader();
            connection.Close();
            f.UpdateGrid();
        }
    }
}
