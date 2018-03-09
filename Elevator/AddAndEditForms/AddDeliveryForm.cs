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
    public partial class AddDeliveryForm : Form
    {
        private AddDeliveryController controller;
        public Delivery delivery;
        public AddDeliveryForm()
        {
            InitializeComponent();
            controller = new AddDeliveryController();
            string[] contractor = DAO.getInstance().getNoteToComboBox("name_contr", "Contractor");
            contractorComboBox.Items.AddRange(contractor);
            if (contractor.Length > 0)
                contractorComboBox.Text = contractorComboBox.Items[0].ToString();
            string[] raw = DAO.getInstance().getNoteToComboBox("name_raw ", "Raw");
            rawComboBox.Items.AddRange(raw);
            if (raw.Length > 0)
                rawComboBox.Text = rawComboBox.Items[0].ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void rawComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] types = DAO.getInstance().getTypeToComboBox("name_type_raw", "Type_raw ", "id_NameRaw ", "name_raw ", "Raw", rawComboBox.Text);
            typeComboBox.Items.AddRange(types);
            if (types.Length > 0)
                typeComboBox.Text = typeComboBox.Items[0].ToString();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] subtypes = DAO.getInstance().getTypeToComboBox("name_subtype", "Subtype_raw ", "id_type ", "name_type_raw ", "Type_raw", typeComboBox.Text);
            subtypeComboBox.Items.AddRange(subtypes);
            if (subtypes.Length > 0)
                subtypeComboBox.Text = subtypeComboBox.Items[0].ToString();
        }
        /* private void getTypes()
{
    typeComboBox.Items.Clear();
    string[] types = DAO.getInstance().getTypes(rawComboBox.Text);
    if (types.Length > 0)
    {
        typeComboBox.Items.AddRange(types);
        typeComboBox.Text = typeComboBox.Items[0].ToString();
    }
}*/
    }
}
