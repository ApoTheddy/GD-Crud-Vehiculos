using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDBProyecto1
{
    public partial class EditVehicleForm : Form
    {
        private ConsesionarioController consesionario_ctrl = new ConsesionarioController();
        private VehicleModel vehicle;
        private FillGridVehiclesCallback callback;

        public EditVehicleForm(VehicleModel vehicle, FillGridVehiclesCallback callback)
        {
            InitializeComponent();

            this.vehicle = vehicle;
            this.callback = callback; 

            LoadData();
        }

        private void LoadData()
        {
            txbPlate.Text = vehicle.GetPlate();
            txbMark.Text = vehicle.GetMark();
            txbModel.Text = vehicle.GetModel();
            cbxColors.SelectedItem = vehicle.GetColor();
            cbxStatus.SelectedItem = vehicle.GetStatus();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            vehicle.SetPlate(txbPlate.Text);
            vehicle.SetMark(txbMark.Text);
            vehicle.SetModel(txbModel.Text);
            vehicle.SetColor(cbxColors.SelectedItem.ToString());
            vehicle.SetStatus(cbxStatus.SelectedItem.ToString());

            string message = consesionario_ctrl.UpdateVehicle(vehicle);
            callback(message);
        }
    }
}
