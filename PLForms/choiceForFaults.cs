using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace PLForms
{
    public partial class choiceForFaults : Form
    {
        public choiceForFaults()
        {
            //Initializes the window to be enable if ther is no elements in the data lists
            InitializeComponent();
            if (FactoryBL.getBL().getAllFaults().Count == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }
        }
        // case add fault - call to the faults window withe value 0
        private void button1_Click(object sender, EventArgs e)
        {
            FaultsFrom fault = new FaultsFrom(0);
            fault.Show();
            Close();            
        }
        // case update fault - call to the faults window withe value 1
        private void button2_Click(object sender, EventArgs e)
        {
            FaultsFrom fault = new FaultsFrom(1);
            fault.Show();
            Close(); 
        }
        // case remove fault - call to the faults window withe value 2
        private void button3_Click(object sender, EventArgs e)
        {
            FaultsFrom fault = new FaultsFrom(2);
            fault.Show();
            Close();
        }
    }
}
