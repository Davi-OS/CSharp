using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curses.Entites
{
    internal class Students
    {
        public int StudentCode { get; set; }

        public Students(int code)
        {
            this.StudentCode = code;
        }
    }
}
