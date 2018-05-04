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
    public partial class AddNormOfGeneralLevelForm : Form
    {
        private AddNormOfRawController controller;
        private GeneralLevelOfQualityNorm generalLevelOfQualityNorm;
        private string type;
        private string subtype;
        private bool forChange = false;
        public AddNormOfGeneralLevelForm(GeneralLevelOfQualityNorm newGeneralLevelOfQualityNorm,
            string[] impurities, string newType, string newSubtype)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();          
            impComboBox.Items.AddRange(impurities);
            impComboBox.Text = impComboBox.Items[0].ToString();
            generalLevelOfQualityNorm = newGeneralLevelOfQualityNorm;
            type = newType;
            subtype = newSubtype;
        }

        public AddNormOfGeneralLevelForm(GeneralLevelOfQualityNorm newGeneralLevelOfQualityNorm,
            bool change)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            this.Text = "Изменение общего показателя качества";
            impComboBox.Items.Add(newGeneralLevelOfQualityNorm.TypeImp);
            impComboBox.Text = newGeneralLevelOfQualityNorm.TypeImp;
            impComboBox.Enabled = false;
            textBoxNorm.Text = newGeneralLevelOfQualityNorm.Norm;
            if (newGeneralLevelOfQualityNorm.Isminimum)
                radioButtonMin.Checked = true;
            else radioButtonMax.Checked = true;
            generalLevelOfQualityNorm = newGeneralLevelOfQualityNorm;
            forChange = change;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string norm = textBoxNorm.Text.Replace(",", ".");
            if (forChange)
            {
                generalLevelOfQualityNorm.Norm = norm;
                if (radioButtonMin.Checked)
                    generalLevelOfQualityNorm.Isminimum = true;
                else if (radioButtonMax.Checked)
                    generalLevelOfQualityNorm.Isminimum = false;
                if (controller.changeClick(generalLevelOfQualityNorm))
                    this.Close();
            }
            else
            {
                if (radioButtonMin.Checked)
                    generalLevelOfQualityNorm.Isminimum = true;
                else if (radioButtonMax.Checked)
                    generalLevelOfQualityNorm.Isminimum = false;
                generalLevelOfQualityNorm.Norm = norm;
                generalLevelOfQualityNorm.TypeImp = impComboBox.Text;
                if (controller.addClick(generalLevelOfQualityNorm, type, subtype))
                    this.Close();
            }                           
        }

        private void textBoxNorm_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(textBoxNorm.Text);
            saveButton.BackColor = controller.checkSave(textBoxNorm.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxNorm.BackColor = !AddlevelOfQualityController.isEmpty(textBoxNorm.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void textBoxNorm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != ',' && (l < '0' || l > '9'))
                e.Handled = true;
        }
    }
}
