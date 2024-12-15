using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace databaseproject
{
    public partial class Form_delete : Form
    {
        private string tablename;
        private List<string> pk;
        private Form1 f;
        private NpgsqlConnection connection;
        private string connectionString;

        public Form_delete(int i, Form1 f)
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
            connection.Close();
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            connection.Open();
            string cmd;
            if (pk.Count == 1) cmd = String.Format("DELETE FROM {0} WHERE {1} = {2}", tablename, pk[0], textBox_pk1.Text);
            else cmd = String.Format("DELETE FROM {0} WHERE {1} = {2} AND {3} = {4}", tablename, pk[0], textBox_pk1.Text, pk[1], textBox_pk2.Text);
            new NpgsqlCommand(cmd, connection).ExecuteReader();
            connection.Close();
            f.UpdateGrid();
        }
    }
}
