using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entitie
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValeuPerHour { get; set; }
        public int Hours { get; set; }
        public HourContract() { }

        public HourContract(DateTime date, double valeuPerHour, int hours)
        {
            Date = date;
            ValeuPerHour = valeuPerHour;
            Hours = hours;
        }

        public double totalVelue()
        {
            return Hours * ValeuPerHour;
        }
    }
}
