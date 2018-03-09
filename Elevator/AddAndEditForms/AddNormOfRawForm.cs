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
        private string norm;
        private string raw;
        private string nameTable;
        private string nameImp;
        private string nameTableNorm;
        private bool forChange;
        private string valueImp;
        private string nameNorm;
        private string numberClass;
        public AddNormOfRawForm(string newNameTable, string newNameImp, LinkedList<string> impurities, string newNorm, string newRaw, string newNameTableNorm, string newNumberClass)
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
        }
        public AddNormOfRawForm(string newValueImp, string valueNorm, string newNameTable, string newRaw, string newNameImp, string newNameNorm, string newNumberClass)
        {
            InitializeComponent();
            controller = new AddNormOfRawController();
            this.Text = "Изменение показателя качества";
            impComboBox.Items.Add(newValueImp);
            impComboBox.Text = newValueImp;
            impComboBox.Enabled = false;
            textBoxImpurity.Text = valueNorm;
            forChange = true;
            nameImp = newNameImp;
            valueImp = newValueImp;
            nameNorm = newNameNorm;
            nameTable = newNameTable;
            raw = newRaw;
            numberClass = newNumberClass;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (forChange)
            {
                if (controller.changeClick(valueImp, nameTable, raw, textBoxImpurity.Text, nameImp, nameNorm, numberClass))
                    this.Close();
            }
            else
            {
                if (controller.addClick(nameTableNorm, nameImp, impComboBox.Text, norm, raw, textBoxImpurity.Text, numberClass))
                    this.Close();
            }
        }

       /*private void impComboBox_SelectedIndexChanged(object sender, EventArgs e)
        /* {
            string[] classes = DAO.getInstance().getClasses();
            impComboBox.Items.AddRange(classes);
            if (classes.Length > 0)
                groupComboBox.Text = groupComboBox.Items[0].ToString();*/
        }
}
