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
    public partial class TransportationForm : Form
    {
        private TransportationController controller;
        public TransportationForm()
        {
            InitializeComponent();
            controller = new TransportationController();
            select();
        }

        private void DeliveryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountOfGrainDataSet.Contractor". При необходимости она может быть перемещена или удалена.
            this.contractorTableAdapter.Fill(this.accountOfGrainDataSet.Contractor);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountOfGrainDataSet.Raw". При необходимости она может быть перемещена или удалена.
            this.rawTableAdapter.Fill(this.accountOfGrainDataSet.Raw);

        }

        private void select()
        {
            dataGridViewDelivery.Rows.Clear();
            string[] columns = { Delivery.DateAttr, Delivery.TransportAttr, Delivery.WeightAttr};
            DAO.getInstance().selectTransportation(Delivery.NameTable, columns, dataGridViewDelivery);
            dataGridViewDelivery.ClearSelection();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.addButtonClick();
            select();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewDelivery.SelectedRows[0];
                Storage storage = new Storage(Convert.ToInt32(dataGridViewDelivery.CurrentRow.Cells[0].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[2].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[3].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[4].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[6].Value));
                Delivery delivery = new Delivery(Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[1].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[5].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[7].Value),
                    Convert.ToString(dataGridViewDelivery.CurrentRow.Cells[8].Value));
                controller.changeButtonClick(storage, delivery);
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
    }
}
