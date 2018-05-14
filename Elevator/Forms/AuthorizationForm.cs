using Elevator.Controllers;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator
{
    public partial class AuthorizationForm : Form
    {
        private EmployeeController employeeController;
        public Employee Empl { get; private set; }
        public AuthorizationForm()
        {
            InitializeComponent();
            loginTextBox.TabStop = false;
            passwordTextBox.TabStop = false;
            employeeController = new EmployeeController();
        }

        private void loginTextBox_Enter(object sender, EventArgs e)
        {
            if (loginTextBox.Text.Equals("Логин"))
            {
                loginTextBox.Clear();
                loginTextBox.ForeColor = Color.Black;
            }
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text.Equals("Пароль"))
            {
                passwordTextBox.Clear();
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.ForeColor = Color.Black;
            }
        }

        private void loginTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTextBox.Text))
            {
                loginTextBox.Text = "Логин";
                loginTextBox.ForeColor = Color.Gray;
            }
        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "Пароль";
                passwordTextBox.ForeColor = Color.Gray;
                passwordTextBox.UseSystemPasswordChar = false;
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != 8 && e.KeyChar != 95 && (e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar < 97 || e.KeyChar > 122) && (e.KeyChar < 1072 || e.KeyChar > 1105)))
            {
                e.Handled = true;
            }
        }

        private void AuthorizationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void authirizationButton_Click_1(object sender, EventArgs e)
        {
            bool isEmpty = false;
            if (loginTextBox.Text.Equals("Логин") || loginTextBox.Text.Trim().Equals(""))
            {
                loginTextBox.Visible = true;
                isEmpty = true;
            }
            if (passwordTextBox.Text.Equals("Пароль") || passwordTextBox.Text.Trim().Equals(""))
            {
                passwordTextBox.Visible = true;
                isEmpty = true;
            }
            if (isEmpty)
            {
                MessageBox.Show("Заполните пустые поля!", "Ошибка входа в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isEmpty = false;
            }
            else
            {
                if (loginTextBox.Text.Trim().Equals("admin") && passwordTextBox.Text.Trim().Equals("admin"))
                {
                    Empl = new Employee("Админ", "", "admin");
                    DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                {
                    try
                    {
                        MD5 md5 = new MD5CryptoServiceProvider();
                        byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(passwordTextBox.Text.Trim()));
                        string resultPassword = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                        Empl = employeeController.GetEmployeeByAuthorization(loginTextBox.Text.Trim(), resultPassword);
                        if (Empl == null)
                        {
                            MessageBox.Show("Неверный логин или пароль!", "Ошибка входа в систему", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            passwordTextBox.Text = "Пароль";
                            passwordTextBox.ForeColor = Color.Gray;
                            passwordTextBox.UseSystemPasswordChar = false;
                        }
                        else
                        {
                            DialogResult = DialogResult.OK;
                            this.Dispose();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка работы с базой данных!", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
