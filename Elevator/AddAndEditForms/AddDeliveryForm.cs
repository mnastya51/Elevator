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
    public partial class AddDeliveryForm : Form
    {
        private AddDeliveryController controller;
        private Delivery delivery;
        private Storage storage;
        private Shipment shipment;
        private double weightBefore;
        private string dateOld;
        private bool loadFormType = true;
        private bool loadFormSubtype = true;
        private bool loadFormContractor = true;
        public AddDeliveryForm()
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            controller = new AddDeliveryController();
            string[] contractor = DAO.getInstance().getNoteToComboBox("name_contr", "Contractor");//выводить неповторяющиеся записи
            contractorComboBox.Items.AddRange(contractor);
            if (contractor.Length > 0)
                contractorComboBox.Text = contractorComboBox.Items[0].ToString();
            string[] raw = DAO.getInstance().getNoteToComboBox("name_raw ", "Raw");
            rawComboBox.Items.AddRange(raw);
            if (raw.Length > 0)
                rawComboBox.Text = rawComboBox.Items[0].ToString();
        }

        public AddDeliveryForm(string text)
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.Text = "Добавление отгрузки";
            controller = new AddDeliveryController();
            string[] contractor = DAO.getInstance().getNoteToComboBox("name_contr", "Contractor");
            contractorComboBox.Items.AddRange(contractor);
            if (contractor.Length > 0)
                contractorComboBox.Text = contractorComboBox.Items[0].ToString();
            string[] raw = DAO.getInstance().getNoteToComboBox("name_raw ", "Raw");
            rawComboBox.Items.AddRange(raw);
            if (raw.Length > 0)
                rawComboBox.Text = rawComboBox.Items[0].ToString();
        }

        public AddDeliveryForm(Storage newStorage, Delivery newDelivery)
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.Text = "Изменение поставки";
            controller = new AddDeliveryController();
            delivery = newDelivery;
            yearNumericUpDown.Text = newStorage.Year;
            string[] contractor = DAO.getInstance().getNoteToComboBox("name_contr", "Contractor");
            contractorComboBox.Items.AddRange(contractor);
            contractorComboBox.Text = newDelivery.Contractor;
            string[] raw = DAO.getInstance().getNoteToComboBox("name_raw ", "Raw");
            storage = newStorage;
            rawComboBox.Items.AddRange(raw);
            rawComboBox.Text = newStorage.Raw;
            transportTextBox.Text = newDelivery.Transport;
            weightTextBox.Text = newDelivery.Weight;
            dateTimePicker.Text = newDelivery.Date;        
        }

        public AddDeliveryForm(Storage newStorage, Shipment newShipment)
        {
            InitializeComponent();
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            this.Text = "Изменение отгрузки";
            controller = new AddDeliveryController();
            string[] contractor = DAO.getInstance().getNoteToComboBox("name_contr", "Contractor");
            contractorComboBox.Items.AddRange(contractor);
            contractorComboBox.Text = newShipment.Contractor;
            string[] raw = DAO.getInstance().getNoteToComboBox("name_raw ", "Raw");
            storage = newStorage;
            rawComboBox.Items.AddRange(raw);
            rawComboBox.Text = newStorage.Raw;
            transportTextBox.Text = newShipment.Transport;
            weightTextBox.Text = newShipment.Weight;
            dateTimePicker.Text = newShipment.Date;
            shipment = newShipment;
            yearNumericUpDown.Text = newStorage.Year;
            weightBefore = Convert.ToDouble(newShipment.Weight);
            dateOld = newShipment.Date;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string weight = weightTextBox.Text.Trim().Replace(",", ".");
            if (this.Text == "Добавление поставки" || this.Text == "Изменение поставки")
            {
                if (delivery == null)
                {
                    Storage storage = new Storage(rawComboBox.Text, typeComboBox.Text, subtypeComboBox.Text,
                        yearNumericUpDown.Text);
                    delivery = new Delivery(contractorComboBox.Text, subdivisionComboBox.Text, dateTimePicker.Text,
                        transportTextBox.Text, weight);
                    if (controller.onSaveClick(delivery, storage, false))
                        this.Close();
                    else
                    {
                        delivery = null;
                        storage = null;
                    }
                }
                else
                {
                    Storage st = new Storage(storage.IdRaw, rawComboBox.Text, typeComboBox.Text, subtypeComboBox.Text, yearNumericUpDown.Text);
                    Delivery del = new Delivery(delivery.Id, contractorComboBox.Text, subdivisionComboBox.Text, dateTimePicker.Text, transportTextBox.Text, weight);
                    if (controller.onSaveClick(del, st, true))
                        this.Close();
                    else
                    {
                        del = null;
                        st = null;
                    }
                }
            }
            else
            {
                if (shipment == null)
                {
                    Storage storage = new Storage(rawComboBox.Text, typeComboBox.Text, subtypeComboBox.Text,
                        yearNumericUpDown.Text);
                    shipment = new Shipment(contractorComboBox.Text, subdivisionComboBox.Text, dateTimePicker.Text,
                         transportTextBox.Text, weight);
                    if (controller.onSaveClick(shipment, storage, false, ""))
                        this.Close();
                    else { shipment = null; storage = null; }
                }
                else
                {
                    Storage st = new Storage(storage.IdRaw, rawComboBox.Text, typeComboBox.Text, subtypeComboBox.Text, yearNumericUpDown.Text);
                    shipment.Contractor = contractorComboBox.Text;
                    shipment.Subdivision = subdivisionComboBox.Text;
                    shipment.Date = dateTimePicker.Text;
                    shipment.Transport = transportTextBox.Text;
                    shipment.Weight = weight;
                    shipment.WeightBefore = weightBefore;
                    shipment.Id = storage.IdRaw;
                       /* = new Shipment(storage.IdRaw, contractorComboBox.Text, subdivisionComboBox.Text, 
                        dateTimePicker.Text, transportTextBox.Text, weight, weightBefore);*/
                    if (controller.onSaveClick(shipment, st, true, dateOld))
                        this.Close();
                   /* else
                    {
                        st = null;
                        shipment = null;
                    }*/
                }
            }
        }

        private void rawComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeComboBox.Items.Clear();
            subtypeComboBox.Items.Clear();
            string[] types = DAO.getInstance().getTypeToComboBox("name_type_raw", "Type_raw ", "id_NameRaw ", "name_raw ", "Raw", rawComboBox.Text);
            typeComboBox.Items.AddRange(types);
            if (loadFormType && storage != null)
            {
                typeComboBox.Text = storage.Type;
                loadFormType = false;
            }
            else if (types.Length > 0)
                typeComboBox.Text = typeComboBox.Items[0].ToString();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subtypeComboBox.Items.Clear();
            string[] subtypes = DAO.getInstance().getSubtypes(typeComboBox.Text, rawComboBox.Text);
            subtypeComboBox.Items.AddRange(subtypes);
            if (loadFormSubtype && storage != null)
            {
                subtypeComboBox.Text = storage.Subtype;
                loadFormSubtype = false;
            }
            if (subtypes.Length > 0)
            {
                subtypeComboBox.Text = subtypeComboBox.Items[0].ToString();
            }
        }

        private void contractorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subdivisionComboBox.Items.Clear();
            string[] subdivisions = DAO.getInstance().getSubdivisionToComboBox(contractorComboBox.Text);
            subdivisionComboBox.Items.AddRange(subdivisions);
            if (loadFormContractor && delivery != null)
            {
                subdivisionComboBox.Text = delivery.Subdivision;
                loadFormContractor = false;
            }
            else if (subdivisions.Length > 0)
            {
                subdivisionComboBox.Text = subdivisionComboBox.Items[0].ToString();
            }
        }

        private void weightTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && l != ',' && (l < '0' || l > '9'))
                e.Handled = true;
        }

        private void weightTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = controller.checkSave(weightTextBox.Text);
            saveButton.BackColor = controller.checkSave(weightTextBox.Text) ? Color.DarkOrange : Color.LightBlue;
            weightTextBox.BackColor = controller.isEmpty(weightTextBox.Text.Replace(" ", "")) ? Color.LightBlue : Color.White;
        }
    }
}
