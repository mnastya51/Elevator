using Elevator.Controllers;
using Elevator.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.AddForms
{
    public partial class AddNoteForm : Form
    {
        private AddNoteController controller;
        int idNameRaw = 0;
        string nameTable;
        string column;
        string parentColumn;
        public Note note;
        public AddNoteForm()
        {
            InitializeComponent();
            controller = new AddNoteController();
        }
        public AddNoteForm(string field, int idName, string newNameTable, string newColumn, string parentCol)
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
            note = new Note(Convert.ToInt32(valueTextBox.Text), idNameRaw);
            if (controller.onSaveClick(note, nameTable, column, parentColumn))
                this.Close();
            else note = null;
        }       
    }
}
