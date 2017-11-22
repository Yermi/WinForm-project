using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLForms
{
    public partial class management : Form
    {
        
        public management()
        {
            InitializeComponent();
        }
        // show the grid window with the value 0 for cars
        private void getAllCars_button_Click(object sender, EventArgs e)
        {
            DataGrid grid = new DataGrid(0);
            grid.Show();
            
        }
        // show the grid window with the value 1 for clients
        private void getAllClients_button_Click(object sender, EventArgs e)
        {
            DataGrid grid = new DataGrid(1);
            grid.Show();            
        }

        // show the grid window with the value 2 for rentings
        private void getAllRentings_button_Click(object sender, EventArgs e)
        {
            DataGrid grid = new DataGrid(2);
            grid.Show();            
        }
        // show the grid window with the value 3 for faults
        private void getAllFaults_button_Click(object sender, EventArgs e)
        {
            DataGrid grid = new DataGrid(3);
            grid.Show();            
        }
        // Initializes the buttons to be enable
        private void management_Load(object sender, EventArgs e)
        {
            getAllCars_button.Enabled = false;
            getAllClients_button.Enabled = false;
            getAllRentings_button.Enabled = false;
            getAllFaults_button.Enabled = false;
        }

        // get a password from user
        private void button1_Click(object sender, EventArgs e)
        {
            // check if password is currect
            if (maskedTextBox1.Text == "1234")
            {
                getAllCars_button.Enabled = true;
                getAllClients_button.Enabled = true;
                getAllRentings_button.Enabled = true;
                getAllFaults_button.Enabled = true;
                maskedTextBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("your password is incorrect, try again");
                getAllCars_button.Enabled = false;
                getAllClients_button.Enabled = false;
                getAllRentings_button.Enabled = false;
                getAllFaults_button.Enabled = false;
            }
        }
    }
}
