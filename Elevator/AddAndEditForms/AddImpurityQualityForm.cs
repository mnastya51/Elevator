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
    public partial class AddImpurityQualityForm : Form
    {
        private FormValue<string, string> formValue;
        private AddImpurityQualityController controller;
        public AddImpurityQualityForm(FormValue<string, string> newFormValue)
        {
            InitializeComponent();
            controller = new AddImpurityQualityController();
            formValue = newFormValue;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (controller.onSaveClick(formValue, textBoxImpurity.Text))
                this.Close();
        }
    }
}
