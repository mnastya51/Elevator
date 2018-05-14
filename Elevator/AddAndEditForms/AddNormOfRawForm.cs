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
    public partial class AddNormOfRawForm : Form
    {
        private AddNormOfRawController controller;
        private HarmfulLevelOfQualityNorm harmfulLevelOfQualityNorm;
        private WeedLevelOfQualityNorm weedLevelOfQualityNorm;
        private GrainLevelOfQualityNorm grainLevelOfQualityNorm;
        private string type;
        private string subtype;
        private bool forChange = false;

        public AddNormOfRawForm(HarmfulLevelOfQualityNorm newharmfulLevelOfQualityNorm, string[] impurities, string newType, string newSubtype)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();          
            impComboBox.Items.AddRange(impurities);
            impComboBox.Text = impComboBox.Items[0].ToString();
            harmfulLevelOfQualityNorm = newharmfulLevelOfQualityNorm;
            type = newType;
            subtype = newSubtype;
        }

        public AddNormOfRawForm(WeedLevelOfQualityNorm newWeedLevelOfQualityNorm, string[] impurities, string newType, string newSubtype)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            impComboBox.Items.AddRange(impurities);           
            impComboBox.Text = impComboBox.Items[0].ToString();
            weedLevelOfQualityNorm = newWeedLevelOfQualityNorm;
            type = newType;
            subtype = newSubtype;
        }

        public AddNormOfRawForm(GrainLevelOfQualityNorm newGrainLevelOfQualityNorm, string[] impurities, string newType, string newSubtype)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();         
            impComboBox.Items.AddRange(impurities);
            impComboBox.Text = impComboBox.Items[0].ToString();
            grainLevelOfQualityNorm = newGrainLevelOfQualityNorm;
            type = newType;
            subtype = newSubtype;
        }

       public AddNormOfRawForm(HarmfulLevelOfQualityNorm newharmfulLevelOfQualityNorm, bool change)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            this.Text = "Изменение вредного показателя качества";
            impComboBox.Items.Add(newharmfulLevelOfQualityNorm.TypeImp);
            impComboBox.Text = newharmfulLevelOfQualityNorm.TypeImp;
            impComboBox.Enabled = false;
            textBoxNorm.Text = newharmfulLevelOfQualityNorm.Norm;
            forChange = change;
            harmfulLevelOfQualityNorm = newharmfulLevelOfQualityNorm;
        }

        public AddNormOfRawForm (WeedLevelOfQualityNorm newWeedLevelOfQualityNorm, bool change)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            this.Text = "Изменение сорного показателя качества";
            impComboBox.Items.Add(newWeedLevelOfQualityNorm.TypeImp);
            impComboBox.Text = newWeedLevelOfQualityNorm.TypeImp;
            impComboBox.Enabled = false;
            textBoxNorm.Text = newWeedLevelOfQualityNorm.Norm;
            forChange = change;
            weedLevelOfQualityNorm = newWeedLevelOfQualityNorm;
        }

        public AddNormOfRawForm(GrainLevelOfQualityNorm newGrainLevelOfQualityNorm, bool change)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            this.Text = "Изменение зернового показателя качества";
            impComboBox.Items.Add(newGrainLevelOfQualityNorm.TypeImp);
            impComboBox.Text = newGrainLevelOfQualityNorm.TypeImp;
            impComboBox.Enabled = false;
            textBoxNorm.Text = newGrainLevelOfQualityNorm.Norm;
            forChange = change;
            grainLevelOfQualityNorm = newGrainLevelOfQualityNorm;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (forChange)
            {
                string norm = textBoxNorm.Text.Trim().Replace(",", ".");
                switch (this.Text)
                {
                    case "Изменение вредного показателя качества":
                        harmfulLevelOfQualityNorm.Norm = norm;
                        if (controller.changeClick(harmfulLevelOfQualityNorm))
                            this.Close();
                        break;
                    case "Изменение сорного показателя качества":
                        weedLevelOfQualityNorm.Norm = norm;
                        if (controller.changeClick(weedLevelOfQualityNorm))
                            this.Close();
                        break;
                    case "Изменение зернового показателя качества":
                        grainLevelOfQualityNorm.Norm = norm;
                        if (controller.changeClick(grainLevelOfQualityNorm))
                            this.Close();
                        break;
                }
            }
            else
            {
                if (harmfulLevelOfQualityNorm != null)
                {
                    harmfulLevelOfQualityNorm.Norm = textBoxNorm.Text;
                    harmfulLevelOfQualityNorm.TypeImp = impComboBox.Text;
                    if (controller.addClick(harmfulLevelOfQualityNorm, type, subtype))
                        this.Close();
                }
                else if (weedLevelOfQualityNorm != null)
                {
                    weedLevelOfQualityNorm.Norm = textBoxNorm.Text;
                    weedLevelOfQualityNorm.TypeImp = impComboBox.Text;
                    if (controller.addClick(weedLevelOfQualityNorm, type, subtype))
                        this.Close();
                }
                else if (grainLevelOfQualityNorm != null)
                {
                    grainLevelOfQualityNorm.Norm = textBoxNorm.Text;
                    grainLevelOfQualityNorm.TypeImp = impComboBox.Text;
                    if (controller.addClick(grainLevelOfQualityNorm, type, subtype))
                        this.Close();
                }
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
