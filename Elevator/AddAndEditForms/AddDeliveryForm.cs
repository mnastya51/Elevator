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
        private bool loadFormType = true;
        private bool loadFormSubtype = true;
        public AddDeliveryForm()
        {
            InitializeComponent();
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
            controller = new AddDeliveryController();
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
            delivery = newDelivery;
            yearNumericUpDown.Text = newStorage.Year;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (delivery == null)
            {
                Storage storage = new Storage(rawComboBox.Text, typeComboBox.Text, subtypeComboBox.Text, 
                    yearNumericUpDown.Text);
                int idRaw = DAO.getInstance().addStorage(storage.Raw, storage.Type, storage.Subtype, 
                    storage.Year);
                delivery = new Delivery(idRaw, contractorComboBox.Text, dateTimePicker.Text,
                    transportTextBox.Text, weightTextBox.Text);
                if (controller.onSaveClick(delivery, false))
                    this.Close();
                else delivery = null;
                /*delivery = new Delivery(contractorComboBox.Text,
                   rawComboBox.Text, typeComboBox.Text, subtypeComboBox.Text
                    dateTimePicker.Text,
                   yearNumericUpDown.Text
                    transportTextBox.Text,
                    weightTextBox.Text);
                if (controller.onSaveClick(delivery, false))
                    this.Close();
                else delivery = null;*/
            }
            else
            {
                Storage st = new Storage(storage.IdRaw, rawComboBox.Text, typeComboBox.Text, subtypeComboBox.Text, yearNumericUpDown.Text);
                Delivery del = new Delivery(storage.IdRaw, contractorComboBox.Text, dateTimePicker.Text, transportTextBox.Text, weightTextBox.Text);
                controller.changeStorage(st, del);
                this.Close();
                /*  contractor.Name = textBoxName.Text;
                  contractor.Sub = textBoxSubdivision.Text;
                  contractor.YurAdress = richTextBoxYuradress.Text;
                  contractor.FactAdress = richTextBoxFactadress.Text;
                  contractor.Index = textBoxIndex.Text.Replace(" ", "") == String.Empty ? 0 : Convert.ToInt32(textBoxIndex.Text);
                  contractor.Phone = maskedTextBoxPhone.Text;
                  contractor.Inn = textBoxINN.Text;
                  if (controller.onSaveClick(contractor, true))
                      this.Close();
                  else delivery = null;*/
            }
            //посмотреть в классах и подтипах, когда я добавляю к сырью наим класса, то тот не удаляется наверно (у которого есть только id класса и наим сырья)
            //добавление и изменение
            //  if ()
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
            if (loadFormSubtype && storage != null)
            {
                subtypeComboBox.Text = storage.Subtype;
                loadFormSubtype = false;
            }
            if (subtypes.Length > 0)
            {
                subtypeComboBox.Items.AddRange(subtypes);
                subtypeComboBox.Text = subtypeComboBox.Items[0].ToString();
            }               
        }
    }
}
