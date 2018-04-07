using Elevator.Controllers;
using Elevator.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Elevator.AddAndEditForms
{
    public partial class AddContractForm : Form
    {
        private AddContractController controller;
        public Contract contract;
        public AddContractForm()
        {
            InitializeComponent();
            controller = new AddContractController();
            string[] contractor = DAO.getInstance().getNoteToComboBox("name_contr", "Contractor");
            contractorComboBox.Items.AddRange(contractor);
            if (contractor.Length > 0)
                contractorComboBox.Text = contractorComboBox.Items[0].ToString();
        }
        public AddContractForm(Contract contr)
        {
            InitializeComponent();
            controller = new AddContractController();
            contract = contr;
            contactTextBox.Text = contr.NameContract;
            contractorComboBox.Items.Add(contr.NameContractor);
            contractorComboBox.Text = contractorComboBox.Items[0].ToString();
            dateTimePicker.Text = contr.Date;
            goalTextBox.Text = contr.Goal;
            contractorComboBox.Enabled = false;
            subdivisionComboBox.Enabled = false;
            contactTextBox.Enabled = false;
            this.Text = "Изменение контрагента";
            contactTextBox.BackColor = Color.White;
            saveButton.Enabled = true;
            saveButton.BackColor = Color.DarkOrange;
        }
       

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (contract == null)
            {
                contract = new Contract(contractorComboBox.Text,
                    subdivisionComboBox.Text,
                    contactTextBox.Text,
                    dateTimePicker.Text,
                    goalTextBox.Text);
                if (controller.onSaveClick(contract, false))
                    this.Close();
                else contract = null;
            }
            else
            {
                contract.NameContract = contactTextBox.Text;
                contract.NameContractor = contractorComboBox.Text;
                contract.Date = dateTimePicker.Text;
                contract.Goal = goalTextBox.Text;            
                if (controller.onSaveClick(contract, true))
                    this.Close();
                else contract = null;
            }
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(contactTextBox.Text);
            saveButton.BackColor = controller.checkSave(contactTextBox.Text) ? Color.DarkOrange : Color.LightBlue;
            contactTextBox.BackColor = !AddContractController.isEmpty(contactTextBox.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void contactorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subdivisionComboBox.Items.Clear();
            string[] subdivisions = DAO.getInstance().getSubdivisionToComboBox(contractorComboBox.Text);
            subdivisionComboBox.Items.AddRange(subdivisions);
            if (contract != null)
            {
                subdivisionComboBox.Text = contract.Subdivision;
            }
            else if (subdivisions.Length > 0)
                subdivisionComboBox.Text = subdivisionComboBox.Items[0].ToString();
        }

        private void goalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && (l < 'А' || l > 'я'))
                e.Handled = true;
        }
    }
}
