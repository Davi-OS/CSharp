using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixação.Entities
{
    internal class Funcionario
    {
        public string Name { get; set; }
        public double Salario { get; set; }
        public string Email { get; set; }

        public Funcionario(string name, string email, double salario)
        {
            this.Email = email;
            this.Name = name;
            this.Salario = salario;
        }
    }
}
