using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    internal class DoubleLinkedNode<T>
    {
        public DoubleLinkedNode<T> NextNode { get; set; }
        public DoubleLinkedNode<T> PrevNode { get; set; }

        public T Data { get; set; }

        public void Insert(T item)
        {
            if (NextNode is null)
            {
                NextNode = new DoubleLinkedNode<T> { Data = item, PrevNode = this };
                return;
            }

            NextNode.Insert(item);
        }
    }
}
