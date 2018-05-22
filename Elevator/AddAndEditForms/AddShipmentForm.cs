using Elevator.Controllers;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.AddAndEditForms
{
    public partial class AddShipmentForm : Form
    {
        private AddShipmentController controller;
        private Shipment shipment;
        public AddShipmentForm()
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            controller = new AddShipmentController();
            string[] contractor = DAO.getInstance().getNoteToComboBox("name_contr", "Contractor");//выводить неповторяющиеся записи
            contractorComboBox.Items.AddRange(contractor);
            if (contractor.Length > 0)
                contractorComboBox.Text = contractorComboBox.Items[0].ToString();
            string[] raw = DAO.getInstance().getNoteToComboBox("name_raw ", "Raw");
            select();
        }

        private void select()
        {
            dataGridViewRaw.Rows.Clear();
            //DAO.getInstance().selectRawForShipment(dataGridViewRaw);
            DAO.getInstance().selectRawForShipment(dataGridViewRaw);
            dataGridViewRaw.ClearSelection();
        }
        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != ',' && (l < '0' || l > '9'))
                e.Handled = true;
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(weightTextBox.Text);
            saveButton.BackColor = controller.checkSave(weightTextBox.Text) ? Color.DarkOrange : Color.LightBlue;
            weightTextBox.BackColor = controller.isEmpty(weightTextBox.Text.Replace(" ", "")) ? Color.LightBlue : Color.White;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(weightTextBox.Text);
            double weightBefore = Convert.ToDouble(dataGridViewRaw.CurrentRow.Cells[5].Value);
            if (weightBefore < weight)
                MessageBox.Show(String.Format("Вес не должен превышать {0} тонн!", weightBefore), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string weightStr = weight.ToString().Replace(",", ".");
                
                shipment = new Shipment(Convert.ToInt32(dataGridViewRaw.CurrentRow.Cells[0].Value), contractorComboBox.Text, subdivisionComboBox.Text, dateTimePicker.Text,
                     transportTextBox.Text, weightStr, Convert.ToString(dataGridViewRaw.CurrentRow.Cells[6].Value),
                     Convert.ToString(dataGridViewRaw.CurrentRow.Cells[7].Value),
                     Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value));
                weightStr = (weightBefore - weight).ToString().Replace(",", ".");

                if (Convert.ToString(dataGridViewRaw.CurrentRow.Cells[6].Value) == "склад")
                {
                    StoreStoragePlace store = new StoreStoragePlace(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value),
                        Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value),
                        Convert.ToString(dataGridViewRaw.CurrentRow.Cells[7].Value), weightStr);
                    if (controller.onSaveClick(shipment, store, Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value)))
                        this.Close();
                    else { shipment = null; }
                }
                else
                {
                    SilageStoragePlace silage = new SilageStoragePlace(Convert.ToString(dataGridViewRaw.CurrentRow.Cells[0].Value),
                        Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value),
                        Convert.ToString(dataGridViewRaw.CurrentRow.Cells[7].Value), weightStr);
                    if (controller.onSaveClick(shipment, silage, Convert.ToString(dataGridViewRaw.CurrentRow.Cells[8].Value)))
                        this.Close();
                    else { shipment = null; }
                }
            }
        }

        private void contractorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subdivisionComboBox.Items.Clear();
            string[] subdivisions = DAO.getInstance().getSubdivisionToComboBox(contractorComboBox.Text);
            subdivisionComboBox.Items.AddRange(subdivisions);
            if (shipment != null)
            {
                subdivisionComboBox.Text = shipment.Subdivision;
            }
            else if (subdivisions.Length > 0)
                subdivisionComboBox.Text = subdivisionComboBox.Items[0].ToString();
        }
    }       
}
