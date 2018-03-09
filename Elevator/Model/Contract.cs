using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Contract
    {
        public int IdConractor { get; set; }
        public string NameContractor { get; set; }
        public string Date { get; set; }
        public string Goal { get; set; }
        public string NameContract { get; set; }

        public Contract()
        {
        }
        public Contract(string nameContractor, string nameContract, string date, string goal)
        {
            this.NameContract = nameContract;
            this.Date = date;
            this.NameContractor = nameContractor;
            this.Goal = goal;
        }
    }
}
