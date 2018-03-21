using Elevator.AddAndEditForms;
using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class NormOfRawController
    {
        /*public void addButtonClick(string nameTable, string nameImp,  LinkedList<string> impurities, string norm, string raw, string nameTableNorm, string numberClass)
        {
            new AddNormOfRawForm(nameTable, nameImp,  impurities, norm, raw, nameTableNorm, numberClass).ShowDialog();
        }*/
        public void addButtonClick(GeneralLevelOfQualityNorm generalLevelOfQualityNorm, LinkedList<string> impurities)
        {
            new AddNormOfRawForm(generalLevelOfQualityNorm, impurities).ShowDialog();
        }
        public void addButtonClick(HarmfulLevelOfQualityNorm hurmfulLevelOfQualityNorm, LinkedList<string> impurities)
        {
            new AddNormOfRawForm(hurmfulLevelOfQualityNorm, impurities).ShowDialog();
        }
        public void addButtonClick(GrainLevelOfQualityNorm grainLevelOfQualityNorm, LinkedList<string> impurities)
        {
            new AddNormOfRawForm(grainLevelOfQualityNorm, impurities).ShowDialog();
        }
        public void addButtonClick(WeedLevelOfQualityNorm weedLevelOfQualityNorm, LinkedList<string> impurities)
        {
            new AddNormOfRawForm(weedLevelOfQualityNorm, impurities).ShowDialog();
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
