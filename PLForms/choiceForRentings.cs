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
    public partial class choiceForRentings : Form
    {
        public choiceForRentings()
        {
            //Initializes the window to be enable if there is no elements in the data lists
            InitializeComponent();
            if (FactoryBL.getBL().getAllRentings().Count == 0)
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button1.Enabled = true;
            }

        }
        // case add renting - call to the rentings window withe value 0
        private void button3_Click(object sender, EventArgs e)
        {
            RentigsForm rent = new RentigsForm(0);
            rent.Show();
            Close();
        }
        // case updade renting - call to the rentings window withe value 1
        private void button2_Click(object sender, EventArgs e)
        {
            RentigsForm rent = new RentigsForm(1);
            rent.Show();
        }
        // case remove renting - call to the rentings window withe value 2
        private void button1_Click(object sender, EventArgs e)
        {
            RentigsForm rent = new RentigsForm(2);
            rent.Show();
                
        }
    }
}
