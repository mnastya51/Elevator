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
using Elevator.Entity;

namespace Elevator.Forms
{
    public partial class AddContractorForm : Form
    {
        private AddContractorController controller;
        public Contractor contractor;
        public AddContractorForm()
        {
            InitializeComponent();
            controller = new AddContractorController();
        }

        public AddContractorForm(Contractor contr)
        {
            InitializeComponent();
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
                    textBoxIndex.Text.Trim() == String.Empty ? 0 : Convert.ToInt32(textBoxIndex.Text),
                    maskedTextBoxPhone.Text,
                    textBoxINN.Text);
                controller.onSaveClick(contractor, false);
            }
            else
            {
                contractor.Name = textBoxName.Text;
                contractor.Sub = textBoxSubdivision.Text;
                contractor.YurAdress = richTextBoxYuradress.Text;
                contractor.FactAdress = richTextBoxFactadress.Text;
                contractor.Index = textBoxIndex.Text.Trim() == String.Empty ? 0 : Convert.ToInt32(textBoxIndex.Text);
                contractor.Phone = maskedTextBoxPhone.Text;
                contractor.Inn = textBoxINN.Text;
                controller.onSaveClick(contractor, true);
            }
            this.Close();
        }
        
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text) ? Color.DarkOrange : Color.Red;
            textBoxName.BackColor = !AddContractorController.isEmpty(textBoxName.Text.Trim()) ? Color.White : Color.Red;
        }

        private void richTextBoxFactadress_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text) ? Color.DarkOrange : Color.Red;
            richTextBoxFactadress.BackColor = !AddContractorController.isEmpty(richTextBoxFactadress.Text.Trim()) ? Color.White : Color.Red;
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            int newIndex = controller.checkIndex(textBoxIndex.Text);
            if (newIndex == -1 && textBoxIndex.Text.Length <= 1)
            {
                textBoxIndex.Text = string.Empty;
            } 
            else
            {
                textBoxIndex.Text = newIndex == -1 ? textBoxIndex.Text.Substring(0, textBoxIndex.Text.Length - 1) : newIndex.ToString();
            }
            textBoxIndex.SelectionStart = textBoxIndex.Text.Length;
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text) ? Color.DarkOrange : Color.Red;
            textBoxIndex.BackColor = controller.checkSaveForIndex(textBoxIndex.Text) ? Color.White : Color.Red;
        }
        

        private void textBoxINN_TextChanged(object sender, EventArgs e)
        {
            Int64 newIndex = controller.checkInn(textBoxINN.Text);
            if (newIndex == -1 && textBoxINN.Text.Length <= 1)
            {
                textBoxINN.Text = string.Empty;
            }
            else
            {
                textBoxINN.Text = newIndex == -1 ? textBoxINN.Text.Substring(0, textBoxINN.Text.Length - 1) : newIndex.ToString();
            }
            textBoxINN.SelectionStart = textBoxINN.Text.Length;
            saveButton.Enabled = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxName.Text, richTextBoxFactadress.Text, textBoxIndex.Text, textBoxINN.Text) ? Color.DarkOrange : Color.Red;
            textBoxINN.BackColor = controller.checkSaveForInn(textBoxINN.Text) ? Color.White : Color.Red;
        }

        private void maskedTextBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
