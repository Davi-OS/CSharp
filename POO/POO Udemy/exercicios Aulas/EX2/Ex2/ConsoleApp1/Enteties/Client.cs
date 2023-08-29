using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Enteties
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime birthDay { get; set; }
        public Client(string nome, string email, string date)
        {
            Name = nome;
            Email = email;
            birthDay = DateTime.Parse(date);
        }
    }
}
