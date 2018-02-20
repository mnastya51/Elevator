﻿using Elevator.Controllers;
using Elevator.Entity;
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
    public partial class AddEmployeeForm : Form
    {
        private AddEmployeeController controller;
        public Employee employee;
        public AddEmployeeForm()
        {
            InitializeComponent();
            controller = new AddEmployeeController();
        }
        public AddEmployeeForm(Employee emp)
        {
            InitializeComponent();
            controller = new AddEmployeeController();
            employee = emp;
            surnameTextBox.Text = emp.Surname;
            nameTextBox.Text = emp.Name;
            secnameTextBox.Text = emp.SecName;
            comboBoxPost.Text = emp.Post;
            loginTextBox.Text = emp.Login;
            this.Text = "Изменение cотрудника";
            surnameTextBox.BackColor = Color.White;
            nameTextBox.BackColor = Color.White;
            secnameTextBox.BackColor = Color.White;
            comboBoxPost.BackColor = Color.White;
            loginTextBox.BackColor = Color.White;
            passwordTextBox.BackColor = Color.White;
            saveButton.Enabled = true;
            saveButton.BackColor = Color.DarkOrange;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                employee = new Employee(surnameTextBox.Text,
                    nameTextBox.Text,
                    secnameTextBox.Text,
                    comboBoxPost.Text,
                    loginTextBox.Text,
                    passwordTextBox.Text);
                controller.onSaveClick(employee, false);
            }
            else
            {
                employee.Surname = surnameTextBox.Text;
                employee.Name = nameTextBox.Text;
                employee.SecName = secnameTextBox.Text;
                employee.Post = comboBoxPost.Text;
                employee.Login = loginTextBox.Text;
                employee.Password = passwordTextBox.Text;
                controller.onSaveClick(employee, true);
            }
            this.Close();
        }

        private void checkSaveForAll()
        {
            saveButton.Enabled = controller.checkSaveForAll(surnameTextBox.Text, nameTextBox.Text, secnameTextBox.Text, loginTextBox.Text, passwordTextBox.Text);
            saveButton.BackColor = controller.checkSaveForAll(surnameTextBox.Text, nameTextBox.Text, secnameTextBox.Text, loginTextBox.Text, passwordTextBox.Text) ? Color.DarkOrange : Color.Red;
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkSaveForAll();
            surnameTextBox.BackColor = !AddEmployeeController.isEmpty(surnameTextBox.Text.Replace(" ", "")) ? Color.White : Color.Red;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkSaveForAll();
            nameTextBox.BackColor = !AddEmployeeController.isEmpty(nameTextBox.Text.Replace(" ", "")) ? Color.White : Color.Red;
        }

        private void secnameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkSaveForAll();
            secnameTextBox.BackColor = !AddEmployeeController.isEmpty(secnameTextBox.Text.Replace(" ", "")) ? Color.White : Color.Red;
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
