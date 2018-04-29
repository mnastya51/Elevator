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
    public partial class AddDateAnalysForm : Form
    {
        private AddDateAnalysController controller;
        private bool change = false;
        private DateAnalys dateAnalys;

        public AddDateAnalysForm(DateAnalys newDateAnalys)
        {
            InitializeComponent();
            dateAnalys = newDateAnalys;
            controller = new AddDateAnalysController();
        }

        public AddDateAnalysForm(DateAnalys newDateAnalys, bool newChange)
        {
            InitializeComponent();
            dateAnalys = newDateAnalys;
            change = newChange;
            controller = new AddDateAnalysController();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dateAnalys.Date = dateTimePicker.Text;
            if (!change && controller.onSaveClick(dateAnalys, false))
                this.Close();
            else if (change)
            {
                if (controller.onSaveClick(dateAnalys, true))
                    this.Close();
            }
        }
    }
}
