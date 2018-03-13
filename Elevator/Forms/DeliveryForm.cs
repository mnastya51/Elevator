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
    public partial class DeliveryForm : Form
    {
        private DeliveryController controller;
        public DeliveryForm()
        {
            InitializeComponent();
            controller = new DeliveryController();
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
            string[] columns = {"date_delivery", "type_transport_delivery", "weight_delivery"};
            DAO.getInstance().selectDelivery("Delivery", columns, dataGridViewDelivery);
            dataGridViewDelivery.ClearSelection();
        }//добавлять тип, если нет его в подтипе, при добавлении хранения

        private void addButton_Click(object sender, EventArgs e)
        {
            controller.addButtonClick();
            select();
        }
    }
}
