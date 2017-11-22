using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BL;

namespace PLForms
{
    public partial class DataGrid : Form
    {
        int choice;
        public DataGrid(int a)
        {
            choice = a;
            InitializeComponent();
        }
        // show the daat in a data grid
        private void DataGrid_Load(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:// show cars
                    this.Text = "Get all cars";
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = FactoryBL.getBL().getAllCars();
                    break;
                case 1:// show clients
                    this.Text = "Get all clients";
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = FactoryBL.getBL().getAllClients();
                    break;
                case 2:// show rentings
                    this.Text = "Get all rentings";
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = FactoryBL.getBL().getAllRentings();
                    break;
                case 3:// show failts
                    this.Text = "Get all faults";
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = FactoryBL.getBL().getAllFaults();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
