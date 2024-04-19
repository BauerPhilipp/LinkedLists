using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    internal class Spider : Animal
    {
        public int Legs { get; set; }

        public Spider(int legs)
        {
            Legs = legs;
        }
        public override string ToString()
        {
            if (Legs > 8) return "Spider mutant!";
            if (Legs < 8) return "Spider veteran!";
            return "Spider";
        }
    }
}
