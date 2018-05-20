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
        private string weightBefore;
        private string idContractor;
        public AddDryForm(string newIdRaw, string idContractor, string newRaw, string weightBefore)
        {
            InitializeComponent();
            controller = new AddDryController();
            idRaw = newIdRaw;
            raw = newRaw;
            this.idContractor = idContractor;
            this.weightBefore = weightBefore;
        }

        public AddDryForm(Drying newDrying)
        {
            InitializeComponent();
            controller = new AddDryController();
            drying = newDrying;
            dateTimePicker.Text = drying.Date;
            weightBefore = drying.WeightBefore;
            textBoxWeightAfter.Text = drying.WeightAfter;
            textBoxWetBefore.Text = drying.WetBefore;
            textBoxWetAfter.Text = drying.WetAfter;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            weightBefore = weightBefore.Replace(",", ".");
            string weightAfter = textBoxWeightAfter.Text.Replace(",", ".");
            string wetBefore = textBoxWetBefore.Text.Replace(",", ".");
            string wetAfter = textBoxWetAfter.Text.Replace(",", ".");
            if (Convert.ToDouble(weightBefore) >= Convert.ToDouble(weightAfter))
            {
                if (drying == null)
                {
                    drying = new Drying(idRaw, idContractor, dateTimePicker.Text,
                        weightBefore != "" ? weightBefore : "null",
                        weightAfter != "" ? weightAfter : "null",
                        wetBefore != "" ? wetBefore : "null",
                        wetAfter != "" ? wetAfter : "null");
                    if (controller.onSaveClick(drying, raw, false))
                        this.Close();
                    else drying = null;
                }
                else
                {
                    drying.Date = dateTimePicker.Text;
                    drying.WeightBefore = weightBefore != "" ? weightBefore : "null";
                    drying.WeightAfter = weightAfter != "" ? weightAfter : "null";
                    drying.WetBefore = wetBefore != "" ? wetBefore : "null";
                    drying.WetAfter = wetAfter != "" ? wetAfter : "null";
                    if (controller.onSaveClick(drying, raw, true))
                        this.Close();
                    else drying = null;
                }
            }
            else
            {
                MessageBox.Show(String.Format("Вес не должен превышать {0} тонн(ы)!", weightBefore), "Сушка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void keyPress(KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != ',' && (l < '0' || l > '9'))
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
