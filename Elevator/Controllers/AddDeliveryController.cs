using Elevator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elevator.Controllers
{
    class AddDeliveryController
    {
        public bool onSaveClick(Delivery delivery, bool forChange)
        {
            if (!forChange)
            {
                if (!DAO.getInstance().addDelivery("Delivery", delivery.Contractor, delivery.Raw, delivery.Type, delivery.Subtype,                
                    new FormValue<string, string>("date_delivery ", delivery.Date), delivery.Year,
                    new FormValue<string, string>("type_transport_delivery ", delivery.Transport),
                    new FormValue<string, string>("weight_delivery ", delivery.Weight)))
                {
                    MessageBox.Show("Данная запись уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else return true;
            }
            else return false;

            /*else
            {
                if (!DAO.getInstance().updateNote("Contractor", new FormValue<string, string>("id_contractor", delivery.ClassId.ToString()),
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
        
    

