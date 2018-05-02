using Elevator.Controllers;
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
    public partial class AddStorageForm : Form
    {
        private AddStorageController controller;
        public AddStorageForm()
        {
            InitializeComponent();
            controller = new AddStorageController();
            comboBoxStorage.Text = comboBoxStorage.Items[0].ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && (l < '0' || l > '9'))
                e.Handled = true;
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSaveForAll(textBoxWeight.Text, textBoxNumber.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxWeight.Text, textBoxNumber.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxNumber.BackColor = controller.isEmpty(textBoxNumber.Text.Replace(" ", "")) ? Color.LightBlue : Color.White;
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSaveForAll(textBoxWeight.Text, textBoxNumber.Text);
            saveButton.BackColor = controller.checkSaveForAll(textBoxWeight.Text, textBoxNumber.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxWeight.BackColor = controller.isEmpty(textBoxWeight.Text.Replace(" ", "")) ? Color.LightBlue : Color.White;
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != '.' && (l < '0' || l > '9'))
                e.Handled = true;
        }
    }
}
