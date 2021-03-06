﻿using Elevator.Controllers;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.AddAndEditForms
{
    public partial class AddNoteForm : Form
    {
        private AddNoteController controller;
        string idNameRaw = "";
        string nameTable;
        string column;
        string parentColumn;
        public RawClass rawClass;
        public AddNoteForm()
        {
            InitializeComponent();
            controller = new AddNoteController();
        }
        public AddNoteForm(string field, string idName, string newNameTable, string newColumn, string parentCol)
        {
            InitializeComponent();
            fieldLabel.Text = field;
            idNameRaw = idName;
            column = newColumn;
            nameTable = newNameTable;
            parentColumn = parentCol;
            controller = new AddNoteController();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            rawClass = new RawClass(Convert.ToInt32(valueTextBox.Value), idNameRaw);
            if (controller.onSaveClick(rawClass, nameTable, column, parentColumn))
                this.Close();
            else rawClass = null;
        }       
    }
}
