using Metodos_Abstratos.Entities;
using System;
using System.Collections.Generic;
using Metodos_Abstratos.Entities.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos
{
    class Circle : Shapes
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color): base(color)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
