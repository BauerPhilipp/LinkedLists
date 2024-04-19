using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    internal class Ant : Animal
    {
        public int Legs { get; set ; }

        public Ant(int legs)
        {
            Legs = legs ;
        }

        public override string ToString()
        {
            if (Legs > 6) return "Ant spezialist!";
            if (Legs < 6) return "Ant ex military";
            return "Ant";
        }
    }
}
