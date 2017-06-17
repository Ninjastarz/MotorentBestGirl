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
    public partial class RegisterJourneyForm : Form
    {
        List<Vehicle> VehicleList;
        public RegisterJourneyForm(List<Vehicle> vehicleList)
        {
            InitializeComponent();
            VehicleList = vehicleList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
