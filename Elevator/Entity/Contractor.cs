using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Entity
{
    public class Contractor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sub { get; set; }
        public string YurAdress { get; set; }
        public string FactAdress { get; set; }
        public int Index { get; set; }
        public string Phone { get; set; }
        public string Inn { get; set; }

        public Contractor()
        {
        }

        public Contractor(int id, string name, string sub, string factAdress)
        {
            this.Id = id;
            this.Sub = name;
            this.YurAdress = sub;
            this.FactAdress = factAdress;
        }
        public Contractor(string name, string sub, string jur_address, string fact_address, int index, string phone, string inn)
        {
            this.Name = name;
            this.Sub = sub;
            this.YurAdress = jur_address;
            this.FactAdress = fact_address;
            this.Index = index;
            this.Phone = phone;
            this.Inn = inn;
        }
        public Contractor(int id, string name, string sub, string jur_address, string fact_address, int index, string phone, string inn)
        {
            this.Id = id;
            this.Name = name;
            this.Sub = sub;
            this.YurAdress = jur_address;
            this.FactAdress = fact_address;
            this.Index = index;
            this.Phone = phone;
            this.Inn = inn;
        }
    }
}
