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
using BE;

namespace PLForms
{
    public partial class choiceForClient : Form
    {
        
        public choiceForClient()
        {
            //Initializes the window to be enable if ther is no elements in the data lists
            InitializeComponent();
            if (FactoryBL.getBL().getAllClients().Count == 0)
            {
                updateClientButton.Enabled = false;
                deleteCluentButton.Enabled = false;
            }
            else
            {
                updateClientButton.Enabled = true;
                deleteCluentButton.Enabled = true;
            }
        }
        // case add client - call to the clients window withe value 0
        private void AddClient_Click(object sender, EventArgs e)
        {
            clientForm clt = new clientForm(0);
            clt.Show();
            Close();
        }
        // case update client - call to the clients window withe value 1
        private void updateClientButton_Click(object sender, EventArgs e)
        {

            clientForm clt = new clientForm(1);
            clt.Show();
        }
        // case remove client - call to the clients window withe value 2
        private void deleteCluentButton_Click(object sender, EventArgs e)
        {
          
            clientForm clt = new clientForm(2);
            clt.Show();
        }
    }
}
