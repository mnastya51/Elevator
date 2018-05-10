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
    public partial class AddClearingForm : Form
    {
        private AddClearingController controller;
        public Clearing clearing;
        private string idRaw;
        private string raw;
        private string idContractor;
        public AddClearingForm(string newIdRaw, string idContractor, string newRaw)
        {
            InitializeComponent();
            controller = new AddClearingController();
            idRaw = newIdRaw;
            raw = newRaw;
            this.idContractor = idContractor;
        }

        public AddClearingForm(Clearing newClearing)
        {
            InitializeComponent();
            controller = new AddClearingController();
            clearing = newClearing;
            dateTimePicker.Text = clearing.Date;
            textBoxWeightBefore.Text = clearing.WeightBefore;
            textBoxWeightAfter.Text = clearing.WeightAfter;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string weightBefore = textBoxWeightBefore.Text.Replace(",", ".");
            string weightAfter = textBoxWeightAfter.Text.Replace(",", ".");
            if (clearing == null)
            {
                clearing = new Clearing(idRaw, idContractor, dateTimePicker.Text,
                    weightBefore != "" ? weightBefore : "null",
                    weightAfter != "" ? weightAfter : "null");
                if (controller.onSaveClick(clearing, raw, false))
                    this.Close();
                else clearing = null;
            }
            else
            {
                clearing.Date = dateTimePicker.Text;
                clearing.WeightBefore = weightBefore != "" ? weightBefore : "null";
                clearing.WeightAfter = weightAfter != "" ? weightAfter : "null";
                if (controller.onSaveClick(clearing, raw, true))
                    this.Close();
                else clearing = null;
            }
        }
        private void keyPress(KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != ',' && (l < '0' || l > '9'))
                e.Handled = true;
        }

        private void textBoxWeightBefore_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void textBoxWeightAfter_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(textBoxWeightAfter.Text);
            saveButton.BackColor = controller.checkSave(textBoxWeightAfter.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxWeightAfter.BackColor = controller.isEmpty(textBoxWeightAfter.Text.Replace(" ", "")) ? Color.LightBlue : Color.White;
        }

        private void textBoxWeightAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }
    }
}
