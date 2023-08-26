using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Entitie.Enums;
namespace ConsoleApp1.Entitie
{
    internal class Worker
    {

        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void removeContract(HourContract contract) { Contracts.Remove(contract); }

        public double income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract item in Contracts)
            {
                if (item.Date.Year == year && item.Date.Month == month)
                {
                    sum += item.totalVelue();
                }
            }
            return sum;
        }
    }
}
