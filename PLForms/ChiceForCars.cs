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
    public partial class ChiceForCars : Form
    {
        public ChiceForCars()
        {
            //Initializes the window to be enable if ther is no elements in the data lists
            InitializeComponent();
            if (FactoryBL.getBL().getAllCars().Count == 0)
            {
                buttonUpdateCar.Enabled = false;
                buttonDeleteCar.Enabled = false;
            }
            else
            {
                buttonUpdateCar.Enabled = true;
                buttonDeleteCar.Enabled = true;
            }
        }

        // case add car - call to the cars window whith the value 0
        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            CarsForm cars = new CarsForm(0);
            cars.Show();
            Close();
        }
        // case update car - call to the cars window withe value 1
        private void buttonUpdateCar_Click(object sender, EventArgs e)
        {
            CarsForm cars = new CarsForm(1);
            cars.Show();
        }

        // case remove car - call to the cars window withe value 2
        private void buttonDeleteCar_Click(object sender, EventArgs e)
        {
            CarsForm cars = new CarsForm(2);
            cars.Show();
        }
    }
}
