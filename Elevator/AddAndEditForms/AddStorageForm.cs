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
        private string raw;
        private string type;
        private string subtype;
        private string classRaw;
        public AddStorageForm(string newIdRaw, string newRaw, string newType, string newSubtype, string newClassRaw)
        {
            InitializeComponent();
            controller = new AddStorageController();
            comboBoxStorage.Text = comboBoxStorage.Items[0].ToString();
            idRaw = newIdRaw;
            raw = newRaw;
            type = newType;
            subtype = newSubtype;
            classRaw = newClassRaw;
        }

        public AddStorageForm(StoreStoragePlace newStore, string newRaw, string newType, string newSubtype, string newClassRaw)
        {
            InitializeComponent();
            controller = new AddStorageController();
            comboBoxStorage.Text = comboBoxStorage.Items[0].ToString();
            store = newStore;
            comboBoxNumber.Text = store.Number;
            number = store.Number;
            textBoxWeight.Text = store.Weight;
            comboBoxStorage.Enabled = false;
            raw = newRaw;
            type = newType;
            subtype = newSubtype;
            classRaw = newClassRaw;
        }

        public AddStorageForm(SilageStoragePlace newSilage, string newRaw, string newType, string newSubtype, string newClassRaw)
        {
            InitializeComponent();
            controller = new AddStorageController();
            comboBoxStorage.Text = comboBoxStorage.Items[1].ToString();
            silage = newSilage;
            comboBoxNumber.Text = silage.Number;
            number = silage.Number;
            textBoxWeight.Text = silage.Weight;
            comboBoxStorage.Enabled = false;
            raw = newRaw;
            type = newType;
            subtype = newSubtype;
            classRaw = newClassRaw;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (comboBoxStorage.Text == "Склад")
            {
                string[] res = DAO.getInstance().correctAddStorage(comboBoxNumber.Text, StoreStoragePlace.NameTable, StoreStoragePlace.NumberAttr);
                if ((raw == res[0] && type == res[1] && subtype == res[2] && classRaw == res[3]) ||
                    (res[0] == null))
                {
                    double capacity = DAO.getInstance().calcCapacity(StoreStoragePlace.NameTable, StoreStoragePlace.WeightAttr,
                        StoreStoragePlace.NumberAttr, comboBoxNumber.Text);
                    double count = capacity + Convert.ToDouble(textBoxWeight.Text);
                    if (count > Store.Capacity)
                        MessageBox.Show(String.Format("Склад переполнен на {0} тонн(ы)! Вместимость 3500 тонн!", count - Store.Capacity), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Сырье не может находится в данном хранилище, произойдет смешивание!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                string[] res = DAO.getInstance().correctAddStorage(comboBoxNumber.Text, SilageStoragePlace.NameTable, SilageStoragePlace.NumberAttr);
                if ((raw == res[0] && type == res[1] && subtype == res[2] && classRaw == res[3]) ||
                    (res[0] == null))
                {
                    double capacity = DAO.getInstance().calcCapacity(SilageStoragePlace.NameTable, SilageStoragePlace.WeightAttr,
                    SilageStoragePlace.NumberAttr, comboBoxNumber.Text);
                    double count = capacity + Convert.ToDouble(textBoxWeight.Text);
                    if (count > Silage.Capacity)
                        MessageBox.Show(String.Format("Силос переполнен на {0} тонн(ы)! Вместимость 150 тонн!", count - Silage.Capacity), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    MessageBox.Show("Сырье не может находится в данном хранилище, произойдет смешивание!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
