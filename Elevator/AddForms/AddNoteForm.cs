using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.AddForms
{
    public partial class AddNoteForm : Form
    {
        public AddNoteForm()
        {
            InitializeComponent();
        }
        public AddNoteForm(string field)
        {
            InitializeComponent();
            fieldLabel.Text = field;
        }
    }
}
