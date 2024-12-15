using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace databaseproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        public void UpdateGrid() 
        {
            if (comboBox1.SelectedItem == null) ;
            else if (comboBox1.SelectedItem.ToString() == "employee")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.employee' table. You can move, or remove it, as needed.
                this.employeeTableAdapter.Fill(this.hotelDataSet1.employee);
                this.dataGridView1.DataSource = this.employeeBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "used")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.used' table. You can move, or remove it, as needed.
                this.usedTableAdapter.Fill(this.hotelDataSet1.used);
                this.dataGridView1.DataSource = this.usedBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "runs")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.runs' table. You can move, or remove it, as needed.
                this.runsTableAdapter.Fill(this.hotelDataSet1.runs);
                this.dataGridView1.DataSource = this.runsBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "room")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.room' table. You can move, or remove it, as needed.
                this.roomTableAdapter.Fill(this.hotelDataSet1.room);
                this.dataGridView1.DataSource = this.roomBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "registers")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.registers' table. You can move, or remove it, as needed.
                this.registersTableAdapter.Fill(this.hotelDataSet1.registers);
                this.dataGridView1.DataSource = this.registersBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "readies")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.readies' table. You can move, or remove it, as needed.
                this.readiesTableAdapter.Fill(this.hotelDataSet1.readies);
                this.dataGridView1.DataSource = this.readiesBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "meal")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.meal' table. You can move, or remove it, as needed.
                this.mealTableAdapter.Fill(this.hotelDataSet1.meal);
                this.dataGridView1.DataSource = this.mealBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "inventory")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.inventory' table. You can move, or remove it, as needed.
                this.inventoryTableAdapter.Fill(this.hotelDataSet1.inventory);
                this.dataGridView1.DataSource = this.inventoryBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "hotel")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.hotel' table. You can move, or remove it, as needed.
                this.hotelTableAdapter.Fill(this.hotelDataSet1.hotel);
                this.dataGridView1.DataSource = this.hotelBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "guest")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.guest' table. You can move, or remove it, as needed.
                this.guestTableAdapter.Fill(this.hotelDataSet1.guest);
                this.dataGridView1.DataSource = this.guestBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "event")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1._event' table. You can move, or remove it, as needed.
                this.eventTableAdapter.Fill(this.hotelDataSet1._event);
                this.dataGridView1.DataSource = this.eventBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "cooks")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.cooks' table. You can move, or remove it, as needed.
                this.cooksTableAdapter.Fill(this.hotelDataSet1.cooks);
                this.dataGridView1.DataSource = this.cooksBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "cooking")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.cooking' table. You can move, or remove it, as needed.
                this.cookingTableAdapter.Fill(this.hotelDataSet1.cooking);
                this.dataGridView1.DataSource = this.cookingBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "cleans")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.cleans' table. You can move, or remove it, as needed.
                this.cleansTableAdapter.Fill(this.hotelDataSet1.cleans);
                this.dataGridView1.DataSource = this.cleansBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "cleaning")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.cleaning' table. You can move, or remove it, as needed.
                this.cleaningTableAdapter.Fill(this.hotelDataSet1.cleaning);
                this.dataGridView1.DataSource = this.cleaningBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "charges")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.charges' table. You can move, or remove it, as needed.
                this.chargesTableAdapter.Fill(this.hotelDataSet1.charges);
                this.dataGridView1.DataSource = this.chargesBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "bill")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.bill' table. You can move, or remove it, as needed.
                this.billTableAdapter.Fill(this.hotelDataSet1.bill);
                this.dataGridView1.DataSource = this.billBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "amenity")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.amenity' table. You can move, or remove it, as needed.
                this.amenityTableAdapter.Fill(this.hotelDataSet1.amenity);
                this.dataGridView1.DataSource = this.amenityBindingSource;
            }
            else if (comboBox1.SelectedItem.ToString() == "admin")
            {
                // TODO: This line of code loads data into the 'hotelDataSet1.admin' table. You can move, or remove it, as needed.
                this.adminTableAdapter.Fill(this.hotelDataSet1.admin);
                this.dataGridView1.DataSource = this.adminBindingSource;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            Form_update form = new Form_update(comboBox1.SelectedIndex,this);
            form.Show();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Form_insert form = new Form_insert(comboBox1.SelectedIndex,this);
            form.Show();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            Form_delete form= new Form_delete(comboBox1.SelectedIndex, this);
            form.Show();
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void button_report_Click(object sender, EventArgs e)
        {
            Form_report form = new Form_report();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_query form = new Form_query(this);
            form.Show();
        }
    }
}
