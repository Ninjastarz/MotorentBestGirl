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
    public partial class AddVehicleForm : Form
    {
        List<Vehicle> VehicleList;
        public AddVehicleForm(List<Vehicle> vehicleList)
        {
            InitializeComponent();
            VehicleList = vehicleList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegisterVehicle_Click(object sender, EventArgs e)
        {
            Vehicle v = new Vehicle(txtManufacturer.Text, txtModel.Text, Int32.Parse(txtMakeYear.Text), txtRegoNo.Text);
            v.FuelEconomy = "Infinity";
            VehicleList.Add(v);
        }
    }
}
