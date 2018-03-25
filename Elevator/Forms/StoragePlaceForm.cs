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

namespace Elevator.Forms
{
    public partial class StoragePlac1Form : Form
    {
        private StoragePlaceController controller;
        private int store;
        private int silage;
        public StoragePlac1Form()
        {
            InitializeComponent();
            controller = new StoragePlaceController();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Store storeClass = new Store(Convert.ToInt32(storeNumericUpDown.Value));
            Silage silageClass = new Silage(Convert.ToInt32(silageNumericUpDown.Value));
            controller.onSaveClick(storeClass, store);
            controller.onSaveClick(silageClass, silage);
            this.Close();
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            storeNumericUpDown.Value = controller.getStorage(Store.NameTable, Store.CountAttr);
            store = Convert.ToInt32(storeNumericUpDown.Value);
            silageNumericUpDown.Value = controller.getStorage(Silage.NameTable, Silage.CountAttr);
            silage = Convert.ToInt32(silageNumericUpDown.Value);
        }
    }
}
