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
    public partial class AddStorageForm : Form
    {
        private AddStorageController controller;
        private string idRaw;
        private StoreStoragePlace store;
        private SilageStoragePlace silage;
        private StoragePlace storagePlace;
        private string number;
        public AddStorageForm(string newIdRaw)
        {
            InitializeComponent();
            controller = new AddStorageController();
            comboBoxStorage.Text = comboBoxStorage.Items[0].ToString();
            idRaw = newIdRaw;
        }

        public AddStorageForm(StoreStoragePlace newStore)
        {
            InitializeComponent();
            controller = new AddStorageController();
            comboBoxStorage.Text = comboBoxStorage.Items[0].ToString();
            store = newStore;
            comboBoxNumber.Text = store.Number;
            number = store.Number;
            textBoxWeight.Text = store.Weight;
            comboBoxStorage.Enabled = false;
        }

        public AddStorageForm(SilageStoragePlace newSilage)
        {
            InitializeComponent();
            controller = new AddStorageController();
            comboBoxStorage.Text = comboBoxStorage.Items[1].ToString();
            silage = newSilage;
            comboBoxNumber.Text = silage.Number;
            number = silage.Number;
            textBoxWeight.Text = silage.Weight;
            comboBoxStorage.Enabled = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (comboBoxStorage.Text == "Склад") {
                double capacity = DAO.getInstance().calcCapacity(StoreStoragePlace.NameTable, StoreStoragePlace.WeightAttr,
                    StoreStoragePlace.NumberAttr, comboBoxNumber.Text);
                if (capacity + Convert.ToDouble(textBoxWeight.Text) > Store.Capacity)
                    MessageBox.Show("Склад переполнен! Вместимость 8 тонн!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //писать в сообщение на сколько переполнено
                else
                {
                    if (store == null)
                    {
                        storagePlace = new StoragePlace(idRaw);
                        store = new StoreStoragePlace(idRaw, comboBoxNumber.Text, textBoxWeight.Text);
                        if (controller.onAddClick(storagePlace, store))
                            this.Close();
                        else store = null;
                    }
                    else
                    {
                        store.Number = comboBoxNumber.Text;
                        store.Weight = textBoxWeight.Text;
                        if (controller.onUpdateClick(store, number))
                            this.Close();
                        else store = null;
                    }
                }
            }
            else
            {
                if (silage == null)
                {
                    storagePlace = new StoragePlace(idRaw);
                    silage = new SilageStoragePlace(idRaw, comboBoxNumber.Text, textBoxWeight.Text);
                    if (controller.onAddClick(storagePlace, silage))
                        this.Close();
                    else silage = null;
                }
                else
                {
                    silage.Number = comboBoxNumber.Text;
                    silage.Weight = textBoxWeight.Text;
                    if (controller.onUpdateClick(silage, number))
                        this.Close();
                    else silage = null;
                }
            }
        }

        private void textBoxWeight_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(textBoxWeight.Text);
            saveButton.BackColor = controller.checkSave(textBoxWeight.Text) ? Color.DarkOrange : Color.LightBlue;
            textBoxWeight.BackColor = controller.isEmpty(textBoxWeight.Text.Replace(" ", "")) ? Color.LightBlue : Color.White;
        }

        private void textBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != '.' && (l < '0' || l > '9'))
                e.Handled = true;
        }

        private void comboBoxStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxNumber.Items.Clear();
            if (comboBoxStorage.Text == "Склад")
            {
                string[] store = DAO.getInstance().getStorageToComboBox("Store");
                comboBoxNumber.Items.AddRange(store);
                if (store.Length > 0)
                    comboBoxNumber.Text = comboBoxNumber.Items[0].ToString();
            }
            else
            {
                string[] store = DAO.getInstance().getStorageToComboBox("Silage");
                comboBoxNumber.Items.AddRange(store);
                if (store.Length > 0)
                    comboBoxNumber.Text = comboBoxNumber.Items[0].ToString();
            }
        }
    }
}
