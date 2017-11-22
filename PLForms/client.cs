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
    public partial class clientForm : Form
    {
        int choice;
        // ctor that sets argoment
        public clientForm(int a)
        {
            choice = a;           
            InitializeComponent();
        }

        private void labelCard_Click(object sender, EventArgs e)
        {

        }
        // event of the button of add/update/remove client
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Client cl;
                switch (choice)
                {
                    case 0: // case add client
                        //check the numbers of the ID
                        if (comboBoxid.Text.Length != 9)
                            throw new Exception("ID number must contain 9 digits");
                        cl = new Client
                        {
                            name = this.textBoxname.Text,
                            Adress = this.AdressText.Text,
                            CardNumber = int.Parse(this.cardText.Text),
                            ID = int.Parse(this.comboBoxid.Text),
                            DateOfBirth = this.dateTimeBirth.Value
                        };
                        BL.FactoryBL.getBL().addClient(cl);// call to the BL fonction
                        MessageBox.Show("the client was added");
                        Close();
                        break;
                    case 1: // case update client
                        Client selectedItem = (Client)this.comboBoxid.Items[this.comboBoxid.SelectedIndex];
                        cl = new Client
                        {
                            name = this.textBoxname.Text,
                            Adress = this.AdressText.Text,
                            CardNumber = int.Parse(this.cardText.Text),
                            ID = (int)(selectedItem.ID),
                            DateOfBirth = this.dateTimeBirth.Value
                        };
                        BL.FactoryBL.getBL().updateClient(selectedItem.ID, cl); //call to the BL function
                        MessageBox.Show("the client was apdated");
                        Close();
                        break;
                    case 2: // case remove client                      
                        int ID = int.Parse(this.comboBoxid.Text);
                        BL.FactoryBL.getBL().remuveClient(ID);
                        MessageBox.Show("the client was removed");
                        Close();
                        break;

                    default:
                        MessageBox.Show("error");
                        break;
                }             
            }
            catch (Exception ex)
            {
                MessageBox.Show("there is a problem: " + ex.Message , "Error");
            }           
        }
        // Initializes the texts and the combo box of the window
        private void client_Load(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    this.Text = "Add client";
                    Addbutton.Text = "add";
                    labelID.Text = "enter ID number: \n(Including check digit)";
                    break;
                case 1:
                    this.Text = "Updet client";
                    Addbutton.Text = "update";
                    comboBoxid.DataSource = null;
                    comboBoxid.DataSource = BL.FactoryBL.getBL().getAllClients();
                    comboBoxid.DisplayMember = "ID";
                    labelID.Text = "choice ID number:";
                    break;
                case 2:
                    this.Text = "delete client";
                    Addbutton.Text = "remove";
                    comboBoxid.DataSource = null;
                    comboBoxid.DataSource = BL.FactoryBL.getBL().GetAllIdByClient();
                    labelID.Text = "choice ID number:";
                    break;
            }
        }
        // seleaction a client from combo box will show its date in the text-boxes
        private void comboBoxid_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    ComboBox comboBox = (ComboBox)sender;
                    Client tempClient = (Client)comboBoxid.SelectedItem;

                    textBoxname.Text = tempClient.name.ToString();
                    dateTimeBirth.Text = tempClient.DateOfBirth.ToString();
                    AdressText.Text = tempClient.Adress.ToString();
                    cardText.Text = tempClient.CardNumber.ToString();

                    break;
                case 2:
                    break;
            }
        }

        private void labelID_Click(object sender, EventArgs e)
        {
        }
    }
}
