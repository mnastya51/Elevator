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
    public partial class AddAnalysQualityRawForm : Form
    {
        private AddAnalysQualityRawController controller;
        private GeneralLevelOfQuality generalLevelOfQuality;
        private HarmfulLevelOfQuality harmfulLevelOfQuality;
        private WeedLevelOfQuality weedLevelOfQuality;
        private GrainLevelOfQuality grainLevelOfQuality;
        private bool forChange = false;
        public AddAnalysQualityRawForm()
        {
            InitializeComponent();
        }

        public AddAnalysQualityRawForm(GeneralLevelOfQuality newGeneralLevelOfQuality, string[] impurities)
        {
            InitializeComponent();
            controller = new AddAnalysQualityRawController();
            impurityComboBox.Items.AddRange(impurities);
            impurityComboBox.Text = impurityComboBox.Items[0].ToString();
            generalLevelOfQuality = newGeneralLevelOfQuality;
        }

        public AddAnalysQualityRawForm(HarmfulLevelOfQuality newHarmfulLevelOfQuality, string[] impurities)
        {
            InitializeComponent();
            controller = new AddAnalysQualityRawController();
            impurityComboBox.Items.AddRange(impurities);
            impurityComboBox.Text = impurityComboBox.Items[0].ToString();
            harmfulLevelOfQuality = newHarmfulLevelOfQuality;
        }

        public AddAnalysQualityRawForm(WeedLevelOfQuality newWeedLevelOfQuality, string[] impurities)
        {
            InitializeComponent();
            controller = new AddAnalysQualityRawController();
            impurityComboBox.Items.AddRange(impurities);
            impurityComboBox.Text = impurityComboBox.Items[0].ToString();
            weedLevelOfQuality = newWeedLevelOfQuality;
        }

        public AddAnalysQualityRawForm(GrainLevelOfQuality newGrainLevelOfQuality, string[] impurities)
        {
            InitializeComponent();
            controller = new AddAnalysQualityRawController();
            impurityComboBox.Items.AddRange(impurities);
            impurityComboBox.Text = impurityComboBox.Items[0].ToString();
            grainLevelOfQuality = newGrainLevelOfQuality;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (forChange)
            {
                switch (this.Text)
                {
                    case "Изменение общего показателя качества":
                        /* generalLevelOfQualityNorm.Norm = textBoxNorm.Text;
                         if (controller.changeClick(generalLevelOfQualityNorm))
                             this.Close();*/
                        break;
                        /*   case "Изменение вредного показателя качества":
                               harmfulLevelOfQualityNorm.Norm = textBoxNorm.Text;
                               if (controller.changeClick(harmfulLevelOfQualityNorm))
                                   this.Close();
                               break;
                           case "Изменение сорного показателя качества":
                               weedLevelOfQualityNorm.Norm = textBoxNorm.Text;
                               if (controller.changeClick(weedLevelOfQualityNorm))
                                   this.Close();
                               break;
                           case "Изменение зернового показателя качества":
                               grainLevelOfQualityNorm.Norm = textBoxNorm.Text;
                               if (controller.changeClick(grainLevelOfQualityNorm))
                                   this.Close();
                               break;*/
                }
            }
            else
            {
                if (generalLevelOfQuality != null)
                {
                    generalLevelOfQuality.Value = valueTextBox.Text;
                    generalLevelOfQuality.LevelQuality = impurityComboBox.Text;
                    if (controller.addClick(generalLevelOfQuality))
                        this.Close();
                }
                else if (harmfulLevelOfQuality != null)
                {
                    harmfulLevelOfQuality.Value = valueTextBox.Text;
                    harmfulLevelOfQuality.LevelQuality = impurityComboBox.Text;
                    if (controller.addClick(harmfulLevelOfQuality))
                        this.Close();
                }
                else if (weedLevelOfQuality != null)
                {
                    weedLevelOfQuality.Value = valueTextBox.Text;
                    weedLevelOfQuality.LevelQuality = impurityComboBox.Text;
                    if (controller.addClick(weedLevelOfQuality))
                        this.Close();
                }
                else if (grainLevelOfQuality != null)
                {
                    grainLevelOfQuality.Value = valueTextBox.Text;
                    grainLevelOfQuality.LevelQuality = impurityComboBox.Text;
                    if (controller.addClick(grainLevelOfQuality))
                        this.Close();
                }
            }        
        }

        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(valueTextBox.Text);
            saveButton.BackColor = controller.checkSave(valueTextBox.Text) ? Color.DarkOrange : Color.LightBlue;
            valueTextBox.BackColor = !AddlevelOfQualityController.isEmpty(valueTextBox.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void valueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != '.' && (l < '0' || l > '9'))
                e.Handled = true;
        }
    }
}
