using System;
using System.Collections.Generic;
using Metodos_Abstratos.Entities.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos.Entities
{
    class Rectangle : Shapes
    {

        public double width { get; set; }
        public double height { get; set; }
        public Rectangle(double width, double height, Color color) : base(color)
        {
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return width * height;
        }
    }
}