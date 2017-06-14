using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assiment_3
{
    public partial class Form1 : Form
    {
        //
        Vehicle[] VehicleArry = new Vehicle[10];
        Vehicle vehicle = new Vehicle();
        int Count = 0;
       
      
        FuelPurchase fuelPurchased = new FuelPurchase();

     
        public Form1()
        {
          
            InitializeComponent();
        }




        private void Car_Data_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manufacturer:  " + VehicleArry[Choose_Car_groupBox.SelectedIndex].GetManufacturer + Environment.NewLine + " Modle:   " +  VehicleArry[Choose_Car_groupBox.SelectedIndex].GetModle + Environment.NewLine + " Make Year:   " + VehicleArry[Choose_Car_groupBox.SelectedIndex].GetMakeYear + Environment.NewLine + "Registration_NO:    " + VehicleArry[Choose_Car_groupBox.SelectedIndex].GetRegistration_NO + Environment.NewLine + VehicleArry[Choose_Car_groupBox.SelectedIndex].Get_TotalKilometers_Travelled + Environment.NewLine + VehicleArry[Choose_Car_groupBox.SelectedIndex].GetTotalSevices);
         
        }



        private void Add_Vehicle_button_Click(object sender, EventArgs e)
        { 
        
             if (Manufacturer_text.Text == string.Empty)
            {
                MessageBox.Show(" Manufacturer text box is empty!");

            }

            else if (Model_textBox.Text == string.Empty)
            {
                MessageBox.Show(" Modle text box is empty!");
            }
            else if (Make_Year_textBox.Text == string.Empty)
            {
                MessageBox.Show("Make Year Textbox is empty");
            }
            else if (Registration_No_textBox.Text == string.Empty)
            {
                MessageBox.Show("Registration NO text box is empty");

            }

            else if (!Int64.TryParse(Make_Year_textBox.Text, out vehicle.make))
            {
                MessageBox.Show(" Make Year textbox dosent have a number in it ");
            }
            else if (Count == 10)
            {
                MessageBox.Show("Sorry you have run out of room to store Vehicles");
            }

            else
            {

             vehicle.GetManufacturer = Manufacturer_text.Text;

                vehicle.GetModle = Model_textBox.Text;

                vehicle.GetRegistration_NO = Registration_No_textBox.Text;

                vehicle.GetMakeYear = Convert.ToInt64(Make_Year_textBox.Text);

                VehicleArry[Count] = vehicle;



                Add_Journey_Combox.Items.Add(VehicleArry[Count].GetManufacturer);
                Choose_Car_groupBox.Items.Add(VehicleArry[Count].GetManufacturer);

                Manufacturer_text.Clear();
                Model_textBox.Clear();
                Registration_No_textBox.Clear();
                Make_Year_textBox.Clear();


                Count++;
            }
         
        }

        private void Add_Journey_Click(object sender, EventArgs e)
        {

            if (Kilometers_travelled_TextBox.Text == string.Empty)
            {
                MessageBox.Show("Kilometers Travelled text box is Empty!");
            }
          
            else if (Fuel_Used_Text_Box.Text == string.Empty)
            {
                MessageBox.Show("Fuel Used text box is Empty");
            }
            else if (!Double.TryParse(Kilometers_travelled_TextBox.Text, out vehicle.kilo))
            {
                MessageBox.Show("kilometers travde");
            }

            else
            {

                Journey Journey1 = new Journey(Convert.ToDouble(Kilometers_travelled_TextBox.Text));
                VehicleArry[Add_Journey_Combox.SelectedIndex].AddJourney(Journey1);

                if (Car_Serviced_checkBox.Checked )
                {
                    vehicle. = false;

                }
                else
                {

                }





            }

        }
    }
}
