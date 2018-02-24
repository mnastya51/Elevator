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
        private string name_imp;
        private string nameTableNorm;
        public AddNormOfRawForm(string newNameTable, string newName_imp, LinkedList<string> impurities, string newNorm, string newRaw, string newNameTableNorm)
        {       
            InitializeComponent();
            controller = new AddNormOfRawController();
            string[] imp = DAO.getInstance().getImpurity(newNameTable, newName_imp, impurities);
            impComboBox.Items.AddRange(imp);
            impComboBox.Text = impComboBox.Items[0].ToString();
            norm = newNorm;
            raw = newRaw;
            nameTable = newNameTable;
            name_imp = newName_imp;
            nameTableNorm = newNameTableNorm;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (controller.onSaveClick(nameTableNorm, name_imp, impComboBox.Text, norm, raw, textBoxImpurity.Text))
                this.Close();
        }
    }
}
