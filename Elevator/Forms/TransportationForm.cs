using Elevator.Controllers;
using Elevator.Model;
using Elevator.Utils;
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
    public partial class TransportationForm : Form
    {
        private TransportationController controller;
        public TransportationForm()
        {
            InitializeComponent();
            controller = new TransportationController();
            select();
        }
        public TransportationForm(string title)
        {
            InitializeComponent();
            this.Text = title;
            controller = new TransportationController();
            select();
        }

        private void select()
        {
            dataGridViewDelivery.Rows.Clear();
            if (this.Text == "Поставка")
            {              
                string[] columns = { Delivery.DateAttr, Delivery.TransportAttr, Delivery.WeightAttr };
                DAO.getInstance().selectTransportation(Delivery.NameTable, columns, dataGridViewDelivery);              
            }
            else
            {
                string[] columns = { Shipment.DateAttr, Shipment.TransportAttr, Shipment.WeightAttr };
                DAO.getInstance().selectTransportation(Shipment.NameTable, columns, dataGridViewDelivery);
            }
            dataGridViewDelivery.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (this.Text == "Поставка")
                controller.addButtonDeliveryClick();
            else controller.addButtonShipmentClick();
            select();                
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewDelivery.SelectedRows[0];
                Storage storage = new Storage(Convert.ToInt32(dataGridViewDelivery.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[3].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[4].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[5].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[7].Value));
                if (this.Text == "Поставка")
                {
                    Delivery delivery = new Delivery(Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[1].Value),
                        Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[2].Value),
                        Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[6].Value),
                        Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[8].Value),
                        Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[9].Value));
                    controller.changeButtonClick(storage, delivery);
                }
                else
                {
                    Shipment shipment = new Shipment(Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[1].Value),
                        Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[2].Value),
                        Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[6].Value),
                        Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[8].Value),
                        Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[9].Value));
                    controller.changeButtonClick(storage, shipment);
                }
                select();
                //int idRaw = DAO.getInstance().changeStorage(storage.IdRaw, storage.Raw, storage.Type, storage.Subtype,
                //    storage.Year);
                /*  Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[4].Value),
                   Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[6].Value),
                      Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[7].Value));

                  dataGridViewContractor.DataSource = DAO.getInstance().selectTable("Contractor");*/
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Выберите запись!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
            select();
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            dataGridViewDelivery.Rows.Clear();
            FilterUtils.FilterFormatter filterFormatter = new FilterUtils.FilterFormatter();
            filterFormatter.addValueWithRegisters("year_crop", yearNumericUpDown.Text);
            filterFormatter.addValueWithRegisters("name_raw", rawTextBox.Text);
            filterFormatter.addValueWithRegisters("name_contr", contractorTextBox.Text);
            string command = "";
            if (this.Text == "Поставка")
            {
                string[] columns = { Delivery.DateAttr, Delivery.TransportAttr, Delivery.WeightAttr };
                command = filterFormatter.getFormattedRequestForTransportation(Delivery.NameTable, columns);
            }
            else
            {
                string[] columns = { Shipment.DateAttr, Shipment.TransportAttr, Shipment.WeightAttr };
                command = filterFormatter.getFormattedRequestForTransportation(Shipment.NameTable, columns);
            }
            DAO.getInstance().findTransportation(command, dataGridViewDelivery);
            dataGridViewDelivery.ClearSelection();
        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
            select();
            rawTextBox.Text = string.Empty;
            contractorTextBox.Text = string.Empty;
            dataGridViewDelivery.ClearSelection();
        }
    }
}
