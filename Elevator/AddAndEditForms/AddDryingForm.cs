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
    public partial class AddDryForm : Form
    {
        private AddDryController controller;
        public Drying drying;
        private string idRaw;
        private string raw;
        public AddDryForm(string newIdRaw, string newRaw)
        {
            InitializeComponent();
            controller = new AddDryController();
            idRaw = newIdRaw;
            raw = newRaw;
        }

        public AddDryForm(Drying newDrying)
        {
            InitializeComponent();
            controller = new AddDryController();
            drying = newDrying;
            dateTimePicker.Text = drying.Date;
            textBoxWeightBefore.Text = drying.WeightBefore;
            textBoxWeightAfter.Text = drying.WeightAfter;
            textBoxWetBefore.Text = drying.WetBefore;
            textBoxWetAfter.Text = drying.WetAfter;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (drying == null)
            {
                drying = new Drying(idRaw, dateTimePicker.Text,
                    textBoxWeightBefore.Text != "" ? textBoxWeightBefore.Text : "null",
                    textBoxWeightAfter.Text != "" ? textBoxWeightAfter.Text : "null",
                    textBoxWetBefore.Text != "" ? textBoxWetBefore.Text : "null",
                    textBoxWetAfter.Text != "" ? textBoxWetAfter.Text : "null");
                if (controller.onSaveClick(drying, raw, false))
                    this.Close();
                else drying = null;
            }
            else
            {
                drying.Date = dateTimePicker.Text;
                drying.WeightBefore = textBoxWeightBefore.Text != "" ? textBoxWeightBefore.Text : "null";
                drying.WeightAfter = textBoxWeightAfter.Text != "" ? textBoxWeightAfter.Text : "null"; 
                drying.WetBefore = textBoxWetBefore.Text != "" ? textBoxWetBefore.Text : "null"; 
                drying.WetAfter = textBoxWetAfter.Text != "" ? textBoxWetAfter.Text : "null"; 
                if (controller.onSaveClick(drying, raw, true))
                    this.Close();
                else drying = null;
            }
        }

        private void keyPress(KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != '.' && (l < '0' || l > '9'))
                e.Handled = true;
        }

        private void textBoxWeightAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void textBoxWeightUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void textBoxHumidityUp_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void textBoxHumidityAfter_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void textBoxWeightAfter_TextChanged(object sender, EventArgs e)
        { 
            saveButton.Enabled = controller.checkSave(textBoxWeightAfter.Text);
            saveButton.BackColor = controller.checkSave(textBoxWeightAfter.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxWeightAfter.BackColor = controller.isEmpty(textBoxWeightAfter.Text.Replace(" ", "")) ? Color.LightBlue : Color.White;
        }       
    }
}
