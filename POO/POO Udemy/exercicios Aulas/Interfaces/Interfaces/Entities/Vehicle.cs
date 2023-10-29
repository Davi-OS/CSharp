using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Entities
{
    class Vehicle
    {
        public string? Model { get; set; }

        public Vehicle(string model)
        {

            this.Model = model;
        }
    }
}
