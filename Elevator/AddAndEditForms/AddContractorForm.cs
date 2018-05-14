using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elevator.Controllers;
using Elevator.Model;

namespace Elevator.AddAndEditForms
{
    public partial class AddContractorForm : Form
    {
        private AddContractorController controller;
        public Contractor contractor;
        public AddContractorForm()
        {
            InitializeComponent();
            controller = new AddContractorController();
            maskedTextBoxPhone.TextChanged += maskedTextBoxPhone_TextChanged;
        }

        public AddContractorForm(Contractor contr)
        {
            InitializeComponent();
            maskedTextBoxPhone.TextChanged += maskedTextBoxPhone_TextChanged;
            controller = new AddContractorController();
            contractor = contr;
            textBoxName.Text = contr.Name;
            textBoxSubdivision.Text = contr.Sub;
            richTextBoxYuradress.Text = contr.YurAdress;
            richTextBoxFactadress.Text = contr.FactAdress;
            textBoxIndex.Text = contr.Index.ToString() == "0" ? string.Empty : contr.Index.ToString();
            maskedTextBoxPhone.Text = contr.Phone;
            textBoxINN.Text = contr.Inn;
            this.Text = "Изменение контрагента";
            textBoxName.BackColor = Color.White;
            richTextBoxFactadress.BackColor = Color.White;
            saveButton.Enabled = true;
            saveButton.BackColor = Color.DarkOrange;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (contractor == null)
            {
                contractor = new Contractor(textBoxName.Text,
                    textBoxSubdivision.Text,
                    richTextBoxYuradress.Text,
                    richTextBoxFactadress.Text,
                    textBoxIndex.Text.Replace(" ", "") == String.Empty ? 0 : Convert.ToInt32(textBoxIndex.Text),
                    maskedTextBoxPhone.Text,
                    textBoxINN.Text);
                if (controller.onSaveClick(contractor, false))
                    this.Close();
                else contractor = null;
            }
            else
            {
                contractor.Name = textBoxName.Text;
                contractor.Sub = textBoxSubdivision.Text;
                contractor.YurAdress = richTextBoxYuradress.Text;
                contractor.FactAdress = richTextBoxFactadress.Text;
                contractor.Index = textBoxIndex.Text.Replace(" ", "") == String.Empty ? 0 : Convert.ToInt32(textBoxIndex.Text);
                contractor.Phone = maskedTextBoxPhone.Text;
                contractor.Inn = textBoxINN.Text;
                if(controller.onSaveClick(contractor, true))
                    this.Close();
                else contractor = null;
            }        
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxName.BackColor = !AddContractorController.isEmpty(textBoxName.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void richTextBoxFactadress_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text) ? Color.DarkOrange : Color.LightBlue;
            richTextBoxFactadress.BackColor = !AddContractorController.isEmpty(richTextBoxFactadress.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void maskedTextBoxPhone_TextChanged(object sender, EventArgs e)
        {
            maskedTextBoxPhone.BackColor = controller.checkPhone(maskedTextBoxPhone.Text) ? Color.White : Color.LightBlue;
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text) ? Color.DarkOrange : Color.LightBlue;
        }

        private void textBoxIndex_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != ',' && (l < '0' || l > '9'))
                e.Handled = true;
            int newIndex = controller.checkIndex(textBoxIndex.Text);
            if (newIndex == -1 && textBoxIndex.Text.Length <= 1)
            {
                textBoxIndex.Text = string.Empty;
            }
            textBoxIndex.SelectionStart = textBoxIndex.Text.Length;
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxIndex.BackColor = controller.checkSaveForIndex(textBoxIndex.Text) ? Color.White : Color.LightBlue;
        }

        private void textBoxINN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != ',' && (l < '0' || l > '9'))
                e.Handled = true;
            Int64 newIndex = controller.checkInn(textBoxINN.Text);
            if (newIndex == -1 && textBoxINN.Text.Length <= 1)
            {
                textBoxINN.Text = string.Empty;
            }
            textBoxINN.SelectionStart = textBoxINN.Text.Length;
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text, maskedTextBoxPhone.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxINN.BackColor = controller.checkSaveForInn(textBoxINN.Text) ? Color.White : Color.LightBlue;
        }
    }
}
