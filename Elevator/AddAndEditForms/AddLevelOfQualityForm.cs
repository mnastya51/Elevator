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
    public partial class AddLevelOfQualityForm : Form
    {
        private FormValue<string, string> formValue;
        private AddlevelOfQualityController controller;
        public AddLevelOfQualityForm(FormValue<string, string> newFormValue)
        {
            InitializeComponent();
            controller = new AddlevelOfQualityController();
            formValue = newFormValue;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (controller.onSaveClick(formValue, textBoxImpurity.Text))
                this.Close();
        }

        private void textBoxImpurity_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(textBoxImpurity.Text);
            saveButton.BackColor = controller.checkSave(textBoxImpurity.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxImpurity.BackColor = !AddlevelOfQualityController.isEmpty(textBoxImpurity.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }
    }
}
