using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modals;

namespace Assessment_3
{
    public partial class MainForm : Form
    {
        BindingList<Vehicle> Vehicles = new BindingList<Vehicle>();
            
        public MainForm()
        {       
            InitializeComponent();

            //binds the comboboxes to the list of vehicles
            cbxAddJourney.DataSource = Vehicles;
            cbxChooseCar.DataSource = Vehicles;
        }

        //binds the comboboxes to show the vahicle registration numbers
        private void cbx_Format(object sender, ListControlConvertEventArgs e)
        {
            e.Value = ((Vehicle)e.Value).RegistrationNo;
        }

        //shows the vehicle information in a message box
        private void Car_Data_Button_Click(object sender, EventArgs e)
        {
            Vehicle selected = Vehicles.ElementAt(cbxChooseCar.SelectedIndex);
            
            MessageBox.Show(selected.PrintToScreen());         
        }

        //creates a new vehicle and adds it to the vehicle list
        private void Add_Vehicle_button_Click(object sender, EventArgs e)
        {
            int makeYear;
             if (txtManufacturer.Text == string.Empty)
            {
                MessageBox.Show(" Manufacturer text box is empty!");

            }
            else if (txtModel.Text == string.Empty)
            {
                MessageBox.Show(" Model text box is empty!");
            }
            else if (Make_Year_textBox.Text == string.Empty)
            {
                MessageBox.Show("Make Year Textbox is empty");
            }
            else if (Registration_No_textBox.Text == string.Empty)
            {
                MessageBox.Show("Registration NO text box is empty");

            }
            else if (!int.TryParse(Make_Year_textBox.Text, out makeYear))
            {
                MessageBox.Show(" Make Year textbox dosent have a number in it ");
            }
            else
            {
                //creates a new vehicle and adds it to the list
                var newVehicle = new Vehicle(txtManufacturer.Text, txtModel.Text, makeYear, Registration_No_textBox.Text);               
                Vehicles.Add(newVehicle);

                //refreshes comboboxes so they show the new vehicle
                cbxAddJourney.Refresh();
                cbxChooseCar.Refresh();

                //clears text boxes
                txtManufacturer.Clear();
                txtModel.Clear();
                Registration_No_textBox.Clear();
                Make_Year_textBox.Clear();
            }
         
        }

        //creates a new journey and fuel purchase and adds them to the car
        private void Add_Journey_Click(object sender, EventArgs e)
        {
            int journeyKilometers;
            int litresFuelUsed;
            Vehicle current = Vehicles.ElementAt(cbxAddJourney.SelectedIndex);

            if (Kilometers_travelled_TextBox.Text == string.Empty)
            {
                MessageBox.Show("Kilometers Travelled text box is Empty!");
            }
          
            else if (Fuel_Used_Text_Box.Text == string.Empty)
            {
                MessageBox.Show("Fuel Used text box is Empty");
            }
    
            else if (!int.TryParse(Kilometers_travelled_TextBox.Text, out journeyKilometers))
            {
                MessageBox.Show("kilometers traveled must be a whole number");
            }

            else if (!int.TryParse(Fuel_Used_Text_Box.Text, out litresFuelUsed))
            {
                MessageBox.Show("Fuel used must be a whole number of litres");
            }

            else
            {
                //creates a new instance of journey and fuelpurchase and adds them to the vehicle
                Journey J = new Journey(journeyKilometers);
                FuelPurchase fp = new FuelPurchase(litresFuelUsed);
                current.AddJourney(J);        
                current.AddFuelPurchase(fp);

                //updates whether car requires service
                Service.CheckServiceNeeded(current);
                current.CalcFuelEconomy();

                Kilometers_travelled_TextBox.Clear();
                Fuel_Used_Text_Box.Clear();
            }
        }

        //services car if needed, says no if not
        private void btnServiceCar_Click(object sender, EventArgs e)
        {
            Vehicle current = Vehicles.ElementAt(cbxChooseCar.SelectedIndex);
            if (current.NeedService)
            {
                Service.ServiceVehicle(current);
                MessageBox.Show($"Your {current.Manufacturer} {current.Model} has successfully been serviced");
            }
            else
            {
                MessageBox.Show($"Your {current.Manufacturer} {current.Model} does not require a service at this time");
            }
        }


        //method to add a rental to a vehicle depending on what rental type it is
        bool isDailyRent;
        private void Rent()
        {
            int Kilometers;
            int Litres;
            int Days;
            string RentType;

            bool daysNeeded = int.TryParse(txtDaysRented.Text, out Days);


            if (isDailyRent)
            {
                RentType = "Daily Rate";
            }
            else
            {
                RentType = "Distance Rate";
            }
            Vehicle current = Vehicles.ElementAt(cbxChooseCar.SelectedIndex);
            if (current.NeedService)
            {
                MessageBox.Show("This vehicle needs a service and so cannot be rented");
            }
            else if (!int.TryParse(txtKmRent.Text, out Kilometers))
            {
                MessageBox.Show("Kilometers travelled must be a whole number");
            }
            else if(!int.TryParse(txtLitresRent.Text, out Litres))
            {
                MessageBox.Show("Litres used must be a whole number");
            }
            else if (isDailyRent && !daysNeeded)
            {
                MessageBox.Show("Days rented must not be blank");
            }
            else
            {
                if (isDailyRent)
                {
                    var Rent = new PerDayRental(Kilometers, Days, Litres);
                    var j = new Journey(Rent.KilometersTravelled);
                    var fp = new FuelPurchase(Rent.LitresUsed);
                    current.AddFuelPurchase(fp);
                    current.AddJourney(j);
                    current.TotalRevenue += Rent.TotalCost;
                }
                else
                {
                    var Rent = new PerKmRental(Kilometers, Litres);
                    var j = new Journey(Rent.KilometersTravelled);
                    var fp = new FuelPurchase(Rent.LitresUsed);
                    current.AddFuelPurchase(fp);
                    current.AddJourney(j);
                    current.TotalRevenue += Rent.TotalCost;
                }
                txtDaysRented.Clear();
                txtKmRent.Clear();
                txtLitresRent.Clear();
                MessageBox.Show($"New {RentType} Rental Successfully Saved");
            }
        }

        private void btnRentDaily_Click(object sender, EventArgs e)
        {
            isDailyRent = true;
            Rent();
        }

        private void btnRentKm_Click(object sender, EventArgs e)
        {
            isDailyRent = false;
            Rent();
        }
    }
}
