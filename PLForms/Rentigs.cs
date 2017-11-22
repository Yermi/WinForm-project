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
    public partial class RentigsForm : Form
    {
        int choice;
        Random r = new Random();
        public RentigsForm(int a)
        {
            choice = a;
            InitializeComponent();
            // check if rhere is anoter driver to acces the group-box
            if (AnotherDriver_checkBox.Checked)
            {
                anotherDriver_groupBox.Visible = true;
                anotherDriverID_comboBox.DataSource = FactoryBL.getBL().getAllClients();
                anotherDriverID_comboBox.DisplayMember = "ID";
            }
            else
            {
                anotherDriver_groupBox.Visible = false;
            }
        }
        // event of the button of add/update/remove rentings
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Renting rent;
                int num_of_drivers = 1;
                switch (choice)
                {
                    case 0: // case add rentings
                        Car selectedLicense = (Car)this.carLicense_comboBox.Items[this.carLicense_comboBox.SelectedIndex];
                        Client selectedF_Id = (Client)this.MdriverID_comboBox.Items[this.MdriverID_comboBox.SelectedIndex];
                        Client selectedAnother_Id = new Client
                            {
                                ID = 999999999,
                                name = "null"
                            };
                        //if there is another driver
                        if (AnotherDriver_checkBox.Checked)
                        {
                           selectedAnother_Id = (Client)this.anotherDriverID_comboBox.Items[this.anotherDriverID_comboBox.SelectedIndex];                        
                           num_of_drivers = 2;
                        }
                        
                        rent = new Renting
                        {
                            Booking = r.Next(100000,999999),
                            start = this.startRent_dateTimePicker.Value,
                            end = this.endRent_dateTimePicker.Value,
                            CarLicense = (int)selectedLicense.License,
                            KM_start = selectedLicense.KM,
                            statusOfRenting = "Ongoing",
                            fault = false,
                            KM_end = 0,
                            price = 0,
                            total_KM = 0,
                            numOfDrivers = num_of_drivers,
                            drivers = new Drivers
                            {
                                ID_firstDriver = (int)selectedF_Id.ID,
                                name_firstDriver = selectedF_Id.name,
                                ID_secendDriver = (int)selectedAnother_Id.ID,
                                name_secendDriver = selectedAnother_Id.name
                            }                           
                        };
                        rent.price = FactoryBL.getBL().price(rent); //call to BL function that return the price of renting

                        // check if license number is from the list of cars
                        if (FactoryBL.getBL().getAllCars().Find(t => t.License == rent.CarLicense) == null)
                            throw new Exception("license number must be from the list of orders");

                        FactoryBL.getBL().addRenting(rent); // call to BL functio
                        MessageBox.Show("the renting was added , the order number is: " + rent.Booking + "\nthe car stand on " + selectedLicense.KM + " KM");
                        Close();
                        break;
                    case 1: // case update renting
                        // select a renting number to update
                        Renting selectBooking = (Renting)this.carLicense_comboBox.Items[this.carLicense_comboBox.SelectedIndex];

                        rent = new Renting
                        {
                            Booking = selectBooking.Booking,
                            start = selectBooking.start,
                            end = selectBooking.end,
                            CarLicense = (int)selectBooking.CarLicense,
                            KM_start = selectBooking.KM_start,
                            drivers = new Drivers                            
                            {
                                 ID_firstDriver = selectBooking.drivers.ID_firstDriver,
                                 name_firstDriver = selectBooking.drivers.name_firstDriver,
                                 ID_secendDriver = selectBooking.drivers.ID_secendDriver,
                                 name_secendDriver = selectBooking.drivers.name_secendDriver
                            },
                            total_KM = int.Parse(totalKM_textBox.Text),
                            statusOfRenting = "end"
                         };
                        rent.KM_end = (rent.KM_start + rent.total_KM); // update the KM
                        if (FactoryBL.getBL().getAllFaults().Find(t => t.License == rent.CarLicense) != null) // check eif the car returning with faults
                            rent.fault = true;
                        //check if the order number is from renting list
                        if (FactoryBL.getBL().getAllRentings().Find(t => t.Booking == rent.Booking) == null)
                            throw new Exception("order number must be from the list of orders");

                        rent.price = FactoryBL.getBL().price(rent);// return the price of renting
                        // check if car is returning before time
                        if (selectBooking.end.Date > DateTime.Now.Date)
                        {
                            MessageBox.Show("returning car before the end of lease will require the client to pay 20 shekel");
                            //rent.end = DateTime.Now.Date;
                            //rent.price = FactoryBL.getBL().price(rent);
                            rent.price = (FactoryBL.getBL().costOfRepair(rent.CarLicense)) + 20;                            
                        }
                        
                        FactoryBL.getBL().updateRenting(selectBooking, rent);// call to BL function
                        MessageBox.Show("the renting was returned, \nthe price for payment: " + rent.price + " shekel");
                        Close();
                        break;
                    case 2:// case remove renting
                        // select a renting to remove
                        Renting selecTBooking = (Renting)this.carLicense_comboBox.Items[this.carLicense_comboBox.SelectedIndex];

                        FactoryBL.getBL().removeRenting(selecTBooking); // call to the BL function
                        MessageBox.Show("the renting was removed");
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("there is a problem: " + ex.Message, "Error");             
            }
        }
        // Initializes the texts and the combo box of the window
        private void RentigsForm_Load(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    this.Text = "rent a car";
                    button1.Text = "add renting";
                    License_label.Text = "Car license:";
                    carLicense_comboBox.DataSource = FactoryBL.getBL().getAllCars();
                    carLicense_comboBox.DisplayMember = "License";
                    MdriverID_comboBox.DataSource = FactoryBL.getBL().getAllClients();
                    MdriverID_comboBox.DisplayMember = "ID";
                    MdriverID_comboBox.DisplayMember = "ID";
                    MdriverID_comboBox.Visible = true;
                    DriverID_label.Visible = true;
                    totalKM_textBox.Visible = false;
                    totalKM_label.Visible = false;
                    price_label.Visible = false;
                    Price_label2.Visible = false;
                    carLicense_comboBox.Visible = true;
                    orderNum_label.Visible = false;
                    ordernum_label1.Visible = false;

                    break;
                case 1:
                    this.Text = "return car";
                    button1.Text = "return";
                    License_label.Text = "Car license:";
                    orderNum_label.Text = "order number:";
                    carLicense_comboBox.DataSource = FactoryBL.getBL().getOngoingRentings();
                    carLicense_comboBox.DisplayMember = "CarLicense";
                    MdriverID_comboBox.DataSource = FactoryBL.getBL().getAllClients();
                    MdriverID_comboBox.DisplayMember = "ID";
                    totalKM_textBox.Visible = true;
                    totalKM_label.Visible = true;
                    MdriverID_comboBox.Visible = false;
                    DriverID_label.Visible = false;                    
                    orderNum_label.Visible = true;
                    ordernum_label1.Visible = true;
                    price_label.Visible = true;
                    Price_label2.Visible = true;
                    AnotherDriver_checkBox.Enabled = false;
                    break;
                case 2:
                    this.Text = "cancel renting";
                    button1.Text = "cancel";
                    License_label.Text = "number order:";
                    orderNum_label.Text = "CarLicense";
                    carLicense_comboBox.DataSource = FactoryBL.getBL().getAllRentings();
                    carLicense_comboBox.DisplayMember = "Booking";
                    totalKM_textBox.Visible = false;
                    totalKM_label.Visible = false;
                    MdriverID_comboBox.Visible = false;
                    DriverID_label.Visible = false;                    
                    orderNum_label.Visible = false;
                    ordernum_label1.Visible = false;
                    price_label.Visible = false;
                    Price_label2.Visible = false;
                    break;
            }
        }
        // seleaction that there is anotehr driver will show the text-boxes
        private void AnotherDriver_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:                   

            if (AnotherDriver_checkBox.Checked)
            {
                anotherDriver_groupBox.Visible = true;
                List<Client> cl = new List<Client>(FactoryBL.getBL().getAllClients());
                anotherDriverID_comboBox.DataSource = cl;
                anotherDriverID_comboBox.DisplayMember = "ID";
            }
            else
            {
                anotherDriver_groupBox.Visible = false;
            }
            break;
                case 1:
            AnotherDriver_checkBox.Enabled = false;


            Renting selectBooking = (Renting)this.carLicense_comboBox.Items[this.carLicense_comboBox.SelectedIndex];
            if (selectBooking.numOfDrivers == 2)
            {

                anotherDriver_groupBox.Visible =  false;
            }
            break;
                case 2:
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    
                    break;
                case 2:
                    break;
            }
        }
        // seleaction a client from combo box will show its date in the text-boxes
        private void carLicense_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (choice)
            {

                case 0:
                    ComboBox combobox1 = (ComboBox)sender;
                    Car temprenting1 = (Car)combobox1.SelectedItem;

                    KM_label.Text = temprenting1.KM.ToString();
                    
                    break;
                case 1:
                    ComboBox comboBox = (ComboBox)sender;
                    Renting tempRenting = (Renting)comboBox.SelectedItem;

                    //tempRenting.price = FactoryBL.getBL().price(tempRenting);
                    //if (tempRenting.end.Date > DateTime.Now.Date)
                    //{
                    //    tempRenting.price += 20;
                    //}

                    ordernum_label1.Text = tempRenting.Booking.ToString();
                    KM_label.Text = tempRenting.KM_start.ToString();
                    Price_label2.Text = tempRenting.price.ToString();
                    startRent_dateTimePicker.Text = tempRenting.start.Date.ToString();
                    endRent_dateTimePicker.Text = tempRenting.end.Date.ToString();
                    break;
                case 2:
                    ComboBox comboBOXs = (ComboBox)sender;
                    Renting TemPRenting = (Renting)comboBOXs.SelectedItem;

                    ordernum_label1.Text = TemPRenting.CarLicense.ToString();
                    KM_label.Text = TemPRenting.KM_start.ToString();
                    Price_label2.Text = TemPRenting.price.ToString();
                    startRent_dateTimePicker.Text = TemPRenting.start.Date.ToString();
                    endRent_dateTimePicker.Text = TemPRenting.end.Date.ToString();
                    break;
            }
        }
        // Initializes the label of the first combo-box
        private void License_label_Click(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    License_label.Text = "Car license:";
                    break;
                case 1:
                    License_label.Text = "Car license:";
                    break;
                case 2:
                    License_label.Text = "number order:";
                    break;
            }

        }

    }
}
