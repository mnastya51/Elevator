﻿using Elevator.AddForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class RawController
    {
        public void addButtonClick()
        {
            new AddRawForm().ShowDialog();
        }
    }
}
