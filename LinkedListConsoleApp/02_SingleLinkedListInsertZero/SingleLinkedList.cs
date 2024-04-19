using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_SingleLinkedListInsertZero
{
    internal class SingleLinkedList<T>
    {
        public Node<T> FirstNode { get; set; }
        private Node<T> LastNodeInserted { get; set; }

        public void AddItem(T data)
        {
            if (FirstNode is null)
            {
                FirstNode = new Node<T> { Data = data};
                LastNodeInserted = FirstNode;
            }

            Node<T> newNode = new Node<T> { Data = data, PrevNode = LastNodeInserted };  
            LastNodeInserted.PrevNode = newNode;

        }

    }
}
