using Elevator.AddAndEditForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class NormOfRawController
    {
        public void addButtonClick(string nameTable, string nameImp,  LinkedList<string> impurities, string norm, string raw, string nameTableNorm, string numberClass)
        {
            new AddNormOfRawForm(nameTable, nameImp,  impurities, norm, raw, nameTableNorm, numberClass).ShowDialog();
        }
        public void changeButtonClick(string valueImp, string valueNorm, string nameTable, string raw, string nameImp, string nameNorm, string numberClass)
        {
            new AddNormOfRawForm(valueImp, valueNorm, nameTable, raw, nameImp, nameNorm, numberClass).ShowDialog();
        }
        public void deleteButtonClick(string nameTable, string nameImp, string valueImp, string raw, string numberClass)
        {
            DAO.getInstance().deleteNorm(nameTable, nameImp, valueImp, raw, numberClass);
        }      
    }
}
