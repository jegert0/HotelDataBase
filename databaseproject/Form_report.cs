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
    public partial class Form_report : Form
    {

        private NpgsqlConnection connection;
        private string connectionString;

        public Form_report()
        {
            InitializeComponent();
            connectionString = "Host = localhost; Database = hotel; User Id = postgres; Password = Bumclood!2456; ";
            connection = new NpgsqlConnection(connectionString);
        }

        private void button_eventorg_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.employeesevents' table. You can move, or remove it, as needed.
            this.employeeseventsTableAdapter.Fill(this.hotelDataSet.employeesevents);
            this.dataGridView1.DataSource = this.employeeseventsBindingSource;
        }

        private void button_highbudget_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.managedhigherbudgets' table. You can move, or remove it, as needed.
            this.managedhigherbudgetsTableAdapter.Fill(this.hotelDataSet.managedhigherbudgets);
            this.dataGridView1.DataSource = this.managedhigherbudgetsBindingSource;
        }

        private void button_manybeds_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.higherbedrooms' table. You can move, or remove it, as needed.
            this.higherbedroomsTableAdapter.Fill(this.hotelDataSet.higherbedrooms);
            this.dataGridView1.DataSource = this.higherbedroomsBindingSource;
        }

        private void button_guestroom_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.managerviewguests' table. You can move, or remove it, as needed.
            this.managerviewguestsTableAdapter.Fill(this.hotelDataSet.managerviewguests);
            this.dataGridView1.DataSource = this.managerviewguestsBindingSource;
        }
    }
}
