using BE;
using BL;
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
    public partial class MainForm : Form
    {
        static public IBL bl;
        public MainForm()
        {            
            InitializeComponent();
            bl = FactoryBL.getBL();            
        }

        private void button1_Click(object sender, EventArgs E)
        {
              
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        // show the window of coooce for clients
        private void clients_Click(object sender, EventArgs e)
        {
            choiceForClient clnt = new choiceForClient(); 
            clnt.Show();
        }
        // show the window of coooce for cars
        private void cars_Click(object sender, EventArgs e)
        {
            ChiceForCars carS = new ChiceForCars();
            carS.Show();
        }
        // show help whindow
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            help help = new help();
            help.Show();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
        // show the window of coooce for rentings
        private void renttings_Click(object sender, EventArgs e)
        {
            choiceForRentings rent = new choiceForRentings();
            rent.Show();
        }

        // show the window of coooce for faults
        private void faults_Click(object sender, EventArgs e)
        {
            choiceForFaults fault = new choiceForFaults();
            fault.Show();
        }

        // show the management window
        private void button1_Click_2(object sender, EventArgs e)
        {
            management manag = new management();
            manag.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
