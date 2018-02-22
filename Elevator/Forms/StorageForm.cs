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

namespace Elevator.Forms
{
    public partial class StorageForm : Form
    {
        private StorageController controller;
        private int store;
        private int silage;
        public StorageForm()
        {
            InitializeComponent();
            controller = new StorageController();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            controller.onSaveClick("Store", Convert.ToInt32(storeNumericUpDown.Value), store, "numb_store");
            controller.onSaveClick("Silage", Convert.ToInt32(silageNumericUpDown.Value), silage, "numb_silage");
            this.Close();
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            storeNumericUpDown.Value = controller.getStorage("Store", "numb_store");
            store = Convert.ToInt32(storeNumericUpDown.Value);
            silageNumericUpDown.Value = controller.getStorage("Silage", "numb_silage");
            silage = Convert.ToInt32(silageNumericUpDown.Value);
        }
    }
}
