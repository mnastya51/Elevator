using Elevator.Controllers;
using Elevator.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.AddForms
{
    public partial class AddRawForm : Form
    {
        private AddRawController controller;
        public Raw raw;
        public AddRawForm()
        {
            InitializeComponent();
            controller = new AddRawController();
        }
        public AddRawForm(Raw newRaw)
        {
            InitializeComponent();
            controller = new AddRawController();
            raw = newRaw;
            textBoxName.Text = newRaw.Name;
            textBoxGost.Text = newRaw.Gost;
            this.Text = "Изменение сырья";
            textBoxName.BackColor = Color.White;
            saveButton.Enabled = true;
            saveButton.BackColor = Color.DarkOrange;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(textBoxName.Text);
            saveButton.BackColor = controller.checkSave(textBoxName.Text) ? Color.DarkOrange : Color.Red;
            textBoxName.BackColor = !AddRawController.isEmpty(textBoxName.Text.Replace(" ", "")) ? Color.White : Color.Red;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (raw == null)
            {
                raw = new Raw(textBoxName.Text, textBoxGost.Text);
                if (controller.onSaveClick(raw, false))
                    this.Close();
                else raw = null;
            }
            else
            {
                raw.Name = textBoxName.Text;
                raw.Gost = textBoxGost.Text;
                if (controller.onSaveClick(raw, true))
                    this.Close();
                else raw = null;
            }
        }
    }
}
