﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entitie
{
    internal class Departament
    {
        public string Name { get; set; }


        public Departament() { }
        public Departament(string nome)
        {
            this.Name = nome;
        }
    }
}
