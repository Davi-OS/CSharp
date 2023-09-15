using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary.Entitie
{
    internal class Candidate
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public Candidate(string name, int votes)
        {
            this.Name = name;
            this.Votes = votes;
        }
    }
}
