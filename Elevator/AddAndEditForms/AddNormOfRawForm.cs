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
        private GeneralLevelOfQualityNorm generalLevelOfQualityNorm;
        private HarmfulLevelOfQualityNorm harmfulLevelOfQualityNorm;
        private WeedLevelOfQualityNorm weedLevelOfQualityNorm;
        private GrainLevelOfQualityNorm grainLevelOfQualityNorm;
       /* private string norm;
        private string raw;
        private string nameTable;
        private string nameImp;
        private string nameTableNorm;*/
        private bool forChange = false;
       /* private string valueImp;
        private string nameNorm;
        private string numberClass;*/
        /* public AddNormOfRawForm(string newNameTable, string newNameImp, LinkedList<string> impurities, string newNorm, string newRaw, string newNameTableNorm, string newNumberClass)
         {       
             InitializeComponent();
             controller = new AddNormOfRawController();
             string[] imp = DAO.getInstance().getImpurity(newNameTable, newNameImp, impurities);
             impComboBox.Items.AddRange(imp);
             if(imp.Length>0)
                 impComboBox.Text = impComboBox.Items[0].ToString();
             norm = newNorm;
             raw = newRaw;
             nameTable = newNameTable;
             nameImp = newNameImp;
             nameTableNorm = newNameTableNorm;
             forChange = false;
             numberClass = newNumberClass;
         }*/
        public AddNormOfRawForm(GeneralLevelOfQualityNorm newGeneralLevelOfQualityNorm, string[] impurities)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            //string[] imp = DAO.getInstance().getImpurity(TypeGeneralLevelOfQuality.NameTable, GeneralLevelOfQualityNorm.TypeOfLevelQualityAttr, impurities);
            impComboBox.Items.AddRange(impurities);
            impComboBox.Text = impComboBox.Items[0].ToString();   
            generalLevelOfQualityNorm = newGeneralLevelOfQualityNorm;
        }

        public AddNormOfRawForm(HarmfulLevelOfQualityNorm newharmfulLevelOfQualityNorm, string[] impurities)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();          
            impComboBox.Items.AddRange(impurities);
            impComboBox.Text = impComboBox.Items[0].ToString();
            harmfulLevelOfQualityNorm = newharmfulLevelOfQualityNorm;
        }

        public AddNormOfRawForm(WeedLevelOfQualityNorm newWeedLevelOfQualityNorm, string[] impurities)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            impComboBox.Items.AddRange(impurities);           
            impComboBox.Text = impComboBox.Items[0].ToString();
            weedLevelOfQualityNorm = newWeedLevelOfQualityNorm;
        }

        public AddNormOfRawForm(GrainLevelOfQualityNorm newGrainLevelOfQualityNorm, string[] impurities)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();         
            impComboBox.Items.AddRange(impurities);
            impComboBox.Text = impComboBox.Items[0].ToString();
            grainLevelOfQualityNorm = newGrainLevelOfQualityNorm;
        }

        /* public AddNormOfRawForm(string newValueImp, string valueNorm, string newNameTable, string newRaw, string newNameImp, string newNameNorm, string newNumberClass)
         {
             InitializeComponent();
             controller = new AddNormOfRawController();
             this.Text = "Изменение показателя качества";
             impComboBox.Items.Add(newValueImp);
             impComboBox.Text = newValueImp;
             impComboBox.Enabled = false;
             textBoxNorm.Text = valueNorm;
             forChange = true;
            /* nameImp = newNameImp;
             valueImp = newValueImp;
             nameNorm = newNameNorm;
             nameTable = newNameTable;
             raw = newRaw;
             numberClass = newNumberClass;
         }*/

        public AddNormOfRawForm(GeneralLevelOfQualityNorm newGeneralLevelOfQualityNorm, bool change)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            this.Text = "Изменение общего показателя качества";
            impComboBox.Items.Add(newGeneralLevelOfQualityNorm.TypeImp);
            impComboBox.Text = newGeneralLevelOfQualityNorm.TypeImp;
            impComboBox.Enabled = false;
            textBoxNorm.Text = newGeneralLevelOfQualityNorm.Norm;
            generalLevelOfQualityNorm = newGeneralLevelOfQualityNorm;
            forChange = change;            
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
                switch (this.Text)
                {
                    case "Изменение общего показателя качества":
                        generalLevelOfQualityNorm.Norm = textBoxNorm.Text;
                        if (controller.changeClick(generalLevelOfQualityNorm))
                            this.Close();
                        break;
                    case "Изменение вредного показателя качества":
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
                        break;
                }
            // if (controller.changeClick(valueImp, nameTable, raw, textBoxImpurity.Text, nameImp, nameNorm, numberClass))
               
                 //if (controller.changeClick(generalLevelOfQualityNorm))
                 //   this.Close();
            
            else
            {// if (controller.addClick(nameTableNorm, nameImp, impComboBox.Text, norm, raw, textBoxImpurity.Text, numberClass))
                if (generalLevelOfQualityNorm != null)
                {
                    generalLevelOfQualityNorm.Norm = textBoxNorm.Text;
                    generalLevelOfQualityNorm.TypeImp = impComboBox.Text;
                    if (controller.addClick(generalLevelOfQualityNorm))
                        this.Close();
                }
                else if(harmfulLevelOfQualityNorm != null)
                {
                    harmfulLevelOfQualityNorm.Norm = textBoxNorm.Text;
                    harmfulLevelOfQualityNorm.TypeImp = impComboBox.Text;
                    if (controller.addClick(harmfulLevelOfQualityNorm))
                        this.Close();
                }
                else if (weedLevelOfQualityNorm != null)
                {
                    weedLevelOfQualityNorm.Norm = textBoxNorm.Text;
                    weedLevelOfQualityNorm.TypeImp = impComboBox.Text;
                    if (controller.addClick(weedLevelOfQualityNorm))
                        this.Close();
                }
                else if (grainLevelOfQualityNorm != null)
                {
                    grainLevelOfQualityNorm.Norm = textBoxNorm.Text;
                    grainLevelOfQualityNorm.TypeImp = impComboBox.Text;
                    if (controller.addClick(grainLevelOfQualityNorm))
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
            if (l != '\b' && l != '.' && (l < '0' || l > '9'))
                e.Handled = true;
        }

        /*private void impComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] classes = DAO.getInstance().getClasses();
            impComboBox.Items.AddRange(classes);
            if (classes.Length > 0)
                groupComboBox.Text = groupComboBox.Items[0].ToString();
        }*/
    }
}
