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
    public partial class FaultsFrom : Form
    {
        int choice;
        // ctor that sets argoment
        public FaultsFrom(int a)
        {
            choice = a;
            InitializeComponent();
        }
        // event of the button of add/update/remove faults
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Fault fault;
                switch (choice)
                {
                    case 0: // case add fault
                        // select a car from the combo-box
                        Car selectedItem = (Car)this.carLicense_comboBox.Items[this.carLicense_comboBox.SelectedIndex];
                        
                        fault = new Fault
                        {
                            License = int.Parse(this.carLicense_comboBox.Text),
                            dateOfFault = this.dateOfFault_dateTimePicker.Value,
                            typeOfFault = (typeFault)typeOfFault_comboBox.SelectedValue,
                            Negligence = Negligence_radioButton.Checked,
                            Price = (FactoryBL.getBL().priceOfFault((typeFault)typeOfFault_comboBox.SelectedValue)),
                            Garage = this.garage_textBox.Text
                        };
                        FactoryBL.getBL().addFault(fault); // call to the BL function
                        MessageBox.Show("the fault was added");
                        Close();
                        break;
                    case 1:// case update client
                        Fault selectedFault = (Fault)this.carLicense_comboBox.Items[this.carLicense_comboBox.SelectedIndex];

                        fault = new Fault
                        {
                            License = selectedFault.License,
                            dateOfFault = this.dateOfFault_dateTimePicker.Value,
                            typeOfFault = (typeFault)typeOfFault_comboBox.SelectedValue,
                            Negligence = Negligence_radioButton.Checked,
                            Price = float.Parse(this.price_label.Text),
                            Garage = this.garage_textBox.Text
                        };
                        FactoryBL.getBL().updateFault(selectedFault,fault);// call to the BL function
                        MessageBox.Show("the fault was apdated");
                        Close();
                        break;
                    case 2: // case remove fault
                        // select a fault that want to remove
                        Fault SelectedFault = (Fault)this.carLicense_comboBox.Items[this.carLicense_comboBox.SelectedIndex];                       

                        FactoryBL.getBL().removeFault(SelectedFault);// call to the BL function
                        MessageBox.Show("the fault was remuved");
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show("there is a problem: " + ex.Message , "Error");
            }
        }
        // Initializes the texts and the combo box of the window
        private void FaultsForm_Load(object sender, EventArgs e)
        {
            typeOfFault_comboBox.DataSource = Enum.GetValues(typeof(typeFault));
            switch (choice)
            {
                case 0:
                    this.Text = "add fault";
                    button1.Text = "add";
                    label4.Enabled = true;
                    price_label.Enabled = true;
                    carLicense_comboBox.DataSource = FactoryBL.getBL().getAllCars();
                    carLicense_comboBox.DisplayMember = "License";
                    break;
                case 1:
                    this.Text = "update fault";
                    button1.Text = " update";
                    label4.Enabled = true;
                    price_label.Enabled = true;
                    carLicense_comboBox.DataSource = FactoryBL.getBL().getAllFaults();
                    carLicense_comboBox.DisplayMember = "License";
                    break;
                case 2:
                    this.Text = "remove fault";
                    button1.Text = "remove";
                    label4.Enabled = true;
                    price_label.Enabled = true;
                    carLicense_comboBox.DataSource = FactoryBL.getBL().getAllFaults();
                    carLicense_comboBox.DisplayMember = "License";
                    break;
            }
        }

        // seleaction a client from combo box will show its date in the text-boxes
        private void carLicense_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    ComboBox combobox = (ComboBox)sender;
                    Fault tempfault = (Fault)combobox.SelectedItem;

                    dateOfFault_dateTimePicker.Text = tempfault.dateOfFault.Date.ToString();
                    typeOfFault_comboBox.Text = tempfault.typeOfFault.ToString();
                    price_label.Text = tempfault.Price.ToString();
                    garage_textBox.Text = tempfault.Garage;
                    break;
                case 2:
                    ComboBox combobox1 = (ComboBox)sender;
                    Fault tempfault1 = (Fault)combobox1.SelectedItem;

                    dateOfFault_dateTimePicker.Text = tempfault1.dateOfFault.Date.ToString();
                    typeOfFault_comboBox.Text = tempfault1.typeOfFault.ToString();
                    price_label.Text = tempfault1.Price.ToString();
                    garage_textBox.Text = tempfault1.Garage.ToString();
                    break;
            }
        }
        // seleaction a client from combo box will show its date in the text-boxes
        private void typeOfFault_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    ComboBox combobox = (ComboBox)sender;
                    typeFault tempfault = (typeFault)combobox.SelectedItem;

                    price_label.Text = FactoryBL.getBL().priceOfFault(tempfault).ToString();
                    break;
                case 1:                   
                    break;
                case 2:
                    break;
            }
        }
    }
}
