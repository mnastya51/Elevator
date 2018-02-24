﻿using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class ImpurityQualityController
    {
        public void addButtonClick(FormValue<string, string> formValue)
        {
            new AddImpurityQualityForm(formValue).ShowDialog();
        }
        public void deleteButtonClick(FormValue<string, string> formValue, string id)
        {
            DAO.getInstance().deleteNote(formValue.getKey(), new FormValue <string, string> (formValue.getValue(), id));
        }
    }
}
