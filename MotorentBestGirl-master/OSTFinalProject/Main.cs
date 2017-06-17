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
namespace OSTFinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        List<Vehicle> VehicleList = new List<Vehicle>();

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            AddVehicleForm VehicleForm = new AddVehicleForm(VehicleList);
            VehicleForm.ShowDialog();
        }

        private void BtnAddJourney_Click(object sender, EventArgs e)
        {
            RegisterJourneyForm JourneyForm = new RegisterJourneyForm(VehicleList);
            JourneyForm.ShowDialog();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach (Vehicle v in VehicleList)
            {
                listBox1.Items.Add($"{v.Manufacturer}, {v.Model}, {v.RegistrationNo}, {v.Year}, {v.ServicesDone(v.KilometersTraveled)}, {v.KilometersTraveled}, {v.FuelEconomy}");
            }
        }
    }
}
