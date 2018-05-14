using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string SecName { get; set; }
        public string Post { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string surname, string name, string secName, string post, string login, string password)
        {
            this.Id = id;
            this.Surname = surname;
            this.Name = name;
            this.SecName = secName;
            this.Post = post;
            this.Login = login;
            this.Password = password;
        }
        public Employee(string surname, string name, string secName, string post, string login, string password)
        {
            this.Surname = surname;
            this.Name = name;
            this.SecName = secName;
            this.Post = post;
            this.Login = login;
            this.Password = password;
        }

        public Employee(string surname, string name, string secName, string post, string login)
        {
            this.Surname = surname;
            this.Name = name;
            this.SecName = secName;
            this.Post = post;
            this.Login = login;
        }

        public Employee(int id, string surname, string name, string secName, string post)
        {
            this.Id = id;
            this.Surname = surname;
            this.Name = name;
            this.SecName = secName;
            this.Post = post;
        }
        public Employee(string surname, string name, string post)
        {
            this.Surname = surname;
            this.Name = name;
            this.Post = post;
        }
    }
}
