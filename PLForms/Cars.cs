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
    // enum of branchs, User convenience only! Another value also obtained
    public enum branch
    {
        Afula,
        Ariel,
        Ashdod,
        Ashkelon,
        Beersheba,
        Eilat,
        Herzliya,
        Haifa,
        Holon,
        Jerusalem,
        Lod,
        Nazareth,
        Netanya,
        Rehovot,
        Tzfat,
        Yavne
    }
    // enum of manufactors, User convenience only! Another value also obtained
    public enum manufactor
    {
        Audi,
        Buick,
        Citroën,
        Fiat,
        Ford,
        Honda,
        Hyundai,
        Kia,
        Mazda,
        Nissan,
        Opel,
        Suzuki,
        Subaro,
        Toyota,
        volvo
    }
    public enum Audi
    {
        A1,
        A3,
        A4,
        A5,
        A6,
        A7,
        A8,
        TT,
        R8,
        Q3,
        Q5,
        Q7
    }
    public enum Buick
    {
        Century,
        LaCrosse,
        Enclave,
        GS,
        Encore,
    }
    public partial class CarsForm : Form
    {
        int choice; 
        // ctor that set argoment
        public CarsForm(int a)
        {
            InitializeComponent();
            choice = a;

        }

        // event of the button of add/update/remove car
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Car car;
                switch (choice)
                {
                    case 0: // case add car
                        //check the license number
                        if (License_comboBox.Text.Length != 7)
                            throw new Exception(" license number must contain 7 digits");
                        car = new Car
                        {
                            License = int.Parse(this.License_comboBox.Text),
                            dateOfProduction = this.ProdactDate_dateTimePicker.Value,
                            branch = this.Branch_comboBox.Text,
                            typeOfCar = new typeOfCar
                            {
                                Manufacturer = this.Manufactor_comboBox.Text,
                                model = this.Model_comboBox.Text,
                                Engine = (int)Engine_numericUpDown.Value
                            },
                            AutoOrManual = (Gear)AoutOrManual_comboBox.SelectedValue,
                            KM = int.Parse(this.KM_textBox.Text),
                            Doors = (int)Doors_numericUpDown.Value,
                            passengers = (int)Passengers_numericUpDown.Value,
                            faults = new List<Fault>()                          
                        };
                        BL.FactoryBL.getBL().addCar(car); // call to the BL function
                       
                        MessageBox.Show("the car was added");
                        Close();
                        break;
                    case 1:// case update car
                        // get a car from the conbo box to update
                        Car selectedItem = (Car)this.License_comboBox.Items[this.License_comboBox.SelectedIndex];

                        car = new Car
                        {
                            License = (int)(selectedItem.License),
                            dateOfProduction = this.ProdactDate_dateTimePicker.Value,
                            branch = this.Branch_comboBox.Text,
                            typeOfCar = new typeOfCar
                            {
                                Manufacturer = this.Manufactor_comboBox.Text,
                                model = this.Model_comboBox.Text,
                                Engine = (int)Engine_numericUpDown.Value
                            },
                            AutoOrManual = (Gear)AoutOrManual_comboBox.SelectedValue,
                            KM = int.Parse(this.KM_textBox.Text),
                            Doors = (int)Doors_numericUpDown.Value,
                            passengers = (int)Passengers_numericUpDown.Value,
                            faults = new List<Fault>()
                        };
                        BL.FactoryBL.getBL().updateCar(selectedItem.License, car);  // call to the BL function         
                        MessageBox.Show("the car was updated");
                        Close();
                        break;
                    case 2: // case remove car
                        // get a licensenumber fron the combo box
                        int license = int.Parse(this.License_comboBox.Text);
                        BL.FactoryBL.getBL().remuveCar(license); // call to the BL function
                        MessageBox.Show("the car was removed");
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
        private void CarsForm_Load(object sender, EventArgs e)
        {
            AoutOrManual_comboBox.DataSource = Enum.GetValues(typeof(Gear));
            Branch_comboBox.DataSource = Enum.GetValues(typeof(branch));
            Manufactor_comboBox.DataSource = Enum.GetValues(typeof(manufactor));
            switch (choice)
            {
                case 0:
                    this.Text = "Add car";
                    button1.Text = "add";
                    break;
                case 1:
                    this.Text = "update car";
                    button1.Text = "update";
                    License_comboBox.DataSource = null;
                    License_comboBox.DataSource = BL.FactoryBL.getBL().getAllCars();
                    License_comboBox.DisplayMember = "License";
                    break;
                case 2:
                    this.Text = "delete car";
                    button1.Text = "remove";
                    License_comboBox.DataSource = null;
                    License_comboBox.DataSource = BL.FactoryBL.getBL().GetAllIdByCar();
                    break;
            }
        }

        // seleaction a car from combo box will show its date in the text-boxes
        private void License_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (choice)
            {
                case 0:
                    break;
                case 1:
                    ComboBox comboBox = (ComboBox)sender;
                    Car tempCar = (Car)License_comboBox.SelectedItem;

                    ProdactDate_dateTimePicker.Text = tempCar.dateOfProduction.ToString();
                    Branch_comboBox.Text = tempCar.branch.ToString();
                    Manufactor_comboBox.Text = tempCar.typeOfCar.Manufacturer.ToString();
                    Model_comboBox.Text = tempCar.typeOfCar.model;
                    Engine_numericUpDown.Value = tempCar.typeOfCar.Engine;
                    AoutOrManual_comboBox.Text = tempCar.AutoOrManual.ToString();
                    KM_textBox.Text = tempCar.KM.ToString();
                    Doors_numericUpDown.Value = tempCar.Doors;
                    Passengers_numericUpDown.Value = tempCar.passengers;

                    break;
                case 2:
                    break;
            }
        }

        private void Manufactor_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBox comboBox = (ComboBox)sender;
            //typeOfCar tempCar = (typeOfCar)Manufactor_comboBox.SelectedItem;
            ////typeOfCar type = new typeOfCar();
            //switch (tempCar.Manufacturer)
            //{
            //    case "Audi":
            //        Model_comboBox.DataSource = Enum.GetValues(typeof(Audi));
            //        break;
            //    case "Buick":
            //        Model_comboBox.DataSource = Enum.GetValues(typeof(Buick));
            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
