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
    public partial class ImpurityQualityForm : Form
    {
        public ImpurityQualityForm()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            if (groupComboBox.Text == "")
                MessageBox.Show("Выберите группу!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                addButton.Enabled = true;
                addButton.BackColor = Color.DarkOrange;
                deleteButton.Enabled = true;
                deleteButton.BackColor = Color.DarkOrange;
                if (groupComboBox.Text == "Общие показатели")
                {

                }
                else if (groupComboBox.Text == "Вредные примеси")
                {

                }
                else if (groupComboBox.Text == "Зерновые примеси")
                {

                }
                else if (groupComboBox.Text == "Сорные примеси")
                {

                }
            }
        }
    }
}
