using System;
using System.Collections.Generic;
using System.Windows.Forms;


public delegate void FillGridVehiclesCallback(string message);

namespace GestionDBProyecto1
{

    public partial class Form1 : Form
    {
        private readonly ConsesionarioController consesionario_ctrl = new ConsesionarioController();

        public Form1()
        {
            InitializeComponent();
            FillGridVehicles();
        }

        void FillGridVehicles()
        {
            dgvVehicles.Rows.Clear();

            List<VehicleModel> vehicles = consesionario_ctrl.GetAllVehicles();
            foreach (VehicleModel vehicle in vehicles)
            {
                dgvVehicles.Rows.Add(vehicle.GetIdVehicle(), vehicle.GetPlate(),
                    vehicle.GetModel(), vehicle.GetMark(), vehicle.GetColor(), vehicle.GetStatus());
            }
        }

        private void btnAddVehicle_Click(object sender, EventArgs e)
        {
            string plate = txbPlate.Text;
            string mark = txbMark.Text;
            string model = txbModel.Text;
            string color = cbxColors.SelectedItem.ToString();

            VehicleModel vehicle = new VehicleModel(plate, mark, model, color);
            string message = consesionario_ctrl.InsertVehicle(vehicle);
            FillGridVehiclesCallbackHandler(message);

        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvVehicles.SelectedRows[0];
                int id_vehicle = Convert.ToInt32(row.Cells[0].Value);
                string message = consesionario_ctrl.DeleteVehicle(id_vehicle);
                FillGridVehiclesCallbackHandler(message);
            }
            else MessageBox.Show("No se selecciono alguna fila", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int id_vehicle = Convert.ToInt32(txbSearch.Text);
            List<VehicleModel> vehicles_found = consesionario_ctrl.GetVehicle(id_vehicle);

            if (vehicles_found.Count > 0)
            {
                dgvVehicles.Rows.Clear();
                foreach (VehicleModel vehicle in vehicles_found)
                    dgvVehicles.Rows.Add(vehicle.GetIdVehicle(), vehicle.GetPlate(),
                     vehicle.GetModel(), vehicle.GetMark(), vehicle.GetColor(), vehicle.GetStatus());
            }
            else FillGridVehiclesCallbackHandler("No se encontraron vehiculos con ese ID");
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvVehicles.SelectedRows[0];
                int id_vehicle = Convert.ToInt32(row.Cells[0].Value);
                string plate = row.Cells[1].Value.ToString();
                string mark = row.Cells[2].Value.ToString();
                string model = row.Cells[3].Value.ToString();
                string color = row.Cells[4].Value.ToString();
                string status = row.Cells[5].Value.ToString();

                EditVehicleForm edit_vehicle_form = new EditVehicleForm(new VehicleModel(
                    id_vehicle, plate, mark, model, color, status), FillGridVehiclesCallbackHandler);
                edit_vehicle_form.Show();
            }
            else MessageBox.Show("No se selecciono alguna fila", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FillGridVehiclesCallbackHandler(string message)
        {
            MessageBox.Show(message, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillGridVehicles();
        }
    }
}
