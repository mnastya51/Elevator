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
        public AddNormOfRawForm(string newNameTable, string newNameImp, LinkedList<string> impurities, string newNorm, string newRaw, string newNameTableNorm)
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
        }
        public AddNormOfRawForm(string newValueImp, string valueNorm, string newNameTable, string newRaw, string newNameImp, string newNameNorm)
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
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (forChange)
            {
                if (controller.changeClick(valueImp, nameTable, raw, textBoxImpurity.Text, nameImp, nameNorm))
                    this.Close();
            }
            else
            {
                if (controller.addClick(nameTableNorm, nameImp, impComboBox.Text, norm, raw, textBoxImpurity.Text))
                    this.Close();
            }
        }
    }
}
