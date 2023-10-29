using System;
using System.Collections.Generic;
using Metodos_Abstratos.Entities.Enums;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_Abstratos.Entities
{
    abstract class Shapes
    {
        public Color color { get; set; }

        public Shapes(Color color)
        {
            this.color = color;
        }

      public abstract double Area(); 
        
    }
}
