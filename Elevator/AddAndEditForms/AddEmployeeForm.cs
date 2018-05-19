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

namespace Elevator.AddAndEditForms
{
    public partial class AddEmployeeForm : Form
    {
        private AddEmployeeController controller;
        private Employee employee;
        private Employee selectEmployee;
        public AddEmployeeForm()
        {
            InitializeComponent();
            controller = new AddEmployeeController();
            comboBoxPost.Text = comboBoxPost.Items[0].ToString();
        }
        public AddEmployeeForm(Employee emp, Employee selectEmployee)
        {
            InitializeComponent();
            controller = new AddEmployeeController();
            employee = emp;
            this.selectEmployee = selectEmployee;
            surnameTextBox.Text = selectEmployee.Surname;
            nameTextBox.Text = selectEmployee.Name;
            secnameTextBox.Text = selectEmployee.SecName;
            comboBoxPost.Text = selectEmployee.Post;
            loginTextBox.Text = selectEmployee.Login;
            this.Text = "Изменение cотрудника";
            surnameTextBox.BackColor = Color.White;
            nameTextBox.BackColor = Color.White;
            secnameTextBox.BackColor = Color.White;
            comboBoxPost.BackColor = Color.White;
            loginTextBox.BackColor = Color.White;
            passwordTextBox.BackColor = Color.White;
            saveButton.Enabled = true;
            saveButton.BackColor = Color.DarkOrange;
            if (!(employee.Post.Equals("Главный бухгалтер") || employee.Post.Equals("admin")))
            {
                surnameTextBox.Enabled = false;
                nameTextBox.Enabled = false;
                secnameTextBox.Enabled = false;
                comboBoxPost.Enabled = false;
                loginTextBox.Enabled = false;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string resultPassword = "";
            if (passwordTextBox.Text.Trim() != "")
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(passwordTextBox.Text.Trim()));
                resultPassword = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            }
            if (selectEmployee == null)
            {
                if (resultPassword != "")
                {
                    selectEmployee = new Employee(surnameTextBox.Text,
                        nameTextBox.Text,
                        secnameTextBox.Text,
                        comboBoxPost.Text,
                        loginTextBox.Text,
                        resultPassword);
                }
                else selectEmployee = new Employee(surnameTextBox.Text,
                       nameTextBox.Text,
                       secnameTextBox.Text,
                       comboBoxPost.Text,
                       loginTextBox.Text);
                if (controller.onSaveClick(selectEmployee, false))
                    this.Close();
                else selectEmployee = null;
            }
            else
            {
                selectEmployee.Surname = surnameTextBox.Text;
                selectEmployee.Name = nameTextBox.Text;
                selectEmployee.SecName = secnameTextBox.Text;
                selectEmployee.Post = comboBoxPost.Text;
                selectEmployee.Login = loginTextBox.Text;
                selectEmployee.Password = resultPassword;
                controller.onSaveClick(selectEmployee, true);
                if (controller.onSaveClick(selectEmployee, true))
                    this.Close();
                else selectEmployee = null;
            }
        }

        private void checkSaveForAll()
        {
            if (selectEmployee == null)
            {
                saveButton.Enabled = controller.checkSaveForAll(surnameTextBox.Text, nameTextBox.Text, secnameTextBox.Text, loginTextBox.Text, passwordTextBox.Text);
                saveButton.BackColor = controller.checkSaveForAll(surnameTextBox.Text, nameTextBox.Text, secnameTextBox.Text, loginTextBox.Text, passwordTextBox.Text) ? Color.DarkOrange : Color.LightBlue;
            }
            else
            {
                saveButton.Enabled = controller.checkSaveForAll(surnameTextBox.Text, nameTextBox.Text, secnameTextBox.Text, loginTextBox.Text);
                saveButton.BackColor = controller.checkSaveForAll(surnameTextBox.Text, nameTextBox.Text, secnameTextBox.Text, loginTextBox.Text) ? Color.DarkOrange : Color.LightBlue;
            }
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkSaveForAll();
            surnameTextBox.BackColor = !AddEmployeeController.isEmpty(surnameTextBox.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkSaveForAll();
            nameTextBox.BackColor = !AddEmployeeController.isEmpty(nameTextBox.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void secnameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkSaveForAll();
            secnameTextBox.BackColor = !AddEmployeeController.isEmpty(secnameTextBox.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            checkSaveForAll();
            loginTextBox.BackColor = !AddEmployeeController.isEmpty(loginTextBox.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (employee == null)
            {
                checkSaveForAll();
                passwordTextBox.BackColor = !AddEmployeeController.isEmpty(passwordTextBox.Text.Replace(" ", "")) ? Color.White : Color.LightBlue;
            }
        }

        private void keyPress(KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l != '\b' && (l < 'А' || l > 'я'))
                e.Handled = true;
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void secnameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyPress(e);
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (employee != null)
            {
                if (employee.Post != selectEmployee.Post && (employee.Post.Equals("Главный бухгалтер") || employee.Post.Equals("admin")))
                {
                    MessageBox.Show("Вы не можете изменить пароль сотрудника!", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    passwordTextBox.Enabled = false;
                }
            }
        }            
    }
}
