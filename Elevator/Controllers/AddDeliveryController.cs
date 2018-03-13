using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Controllers
{
    class AddDeliveryController
    {
        public void onSaveClick(Delivery delivery, bool forChange)
        {
            if (!forChange)
            {
                 /*  if (!DAO.getInstance().addNote("Delivery", new FormValue<string, string>("name_contr", delivery.Contractor),
                       new FormValue<string, string>("name_raw ", delivery.Raw),
                       new FormValue<string, string>("name_type_raw", delivery.Type),
                       new FormValue<string, string>("name_subtype", delivery.Subtype),
                       new FormValue<string, string>("date_delivery ", delivery.Date),
                       new FormValue<string, string>("phone", delivery.Phone.Replace(" ", "").Length == 14 ? delivery.Phone : string.Empty),
                       new FormValue<string, string>("inn", delivery.Inn.ToString())))
                   {
                       MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       return false;
                   }
                   else return true;
               }
               else
               {
                   if (!DAO.getInstance().updateNote("Contractor", new FormValue<string, string>("id_contractor", delivery.Id.ToString()),
                       new FormValue<string, string>("name_contr", delivery.Name),
                       new FormValue<string, string>("subdivision ", delivery.Sub),
                       new FormValue<string, string>("jur_address", delivery.YurAdress),
                       new FormValue<string, string>("fact_address", delivery.FactAdress),
                       new FormValue<string, string>("mail_index", delivery.Index.ToString().Replace(" ", "") == "0" ? string.Empty : delivery.Index.ToString()),
                       new FormValue<string, string>("phone", delivery.Phone.Replace(" ", "").Length == 14 ? delivery.Phone : string.Empty),
                       new FormValue<string, string>("inn", delivery.Inn.ToString())))
                   {
                       MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       return false;
                   }
                   else return true;*/
                
            }
        }
    }
}
