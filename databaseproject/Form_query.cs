using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseproject
{
    public partial class Form_query : Form
    {
        private Form1 f;
        private NpgsqlConnection connection;
        public Form_query(Form1 f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Host = localhost; Database = hotel; User Id = postgres; Password = Bumclood!2456; ";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = textBox_query.Text;


            NpgsqlCommand sqlCmd = new NpgsqlCommand();
            sqlCmd.Connection = connection;
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = query;
            NpgsqlDataAdapter sqlDataAdap = new NpgsqlDataAdapter(sqlCmd);
            DataTable dtRecord = new DataTable();

            //sqlCmd.ExecuteReader();

            sqlDataAdap.Fill(dtRecord);
            dataGridView1.DataSource = dtRecord;

            connection.Close();
            f.UpdateGrid();
        }
    }
}
