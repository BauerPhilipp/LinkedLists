using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingleLinkedList
{
    /// <summary>
    /// Node for the List-Item
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class Node<T>
    {
        /// <summary>
        /// Item stored in Node
        /// </summary>
        public T Value { get; set; }
        public Node<T> PrevNode { get;  private set; }

        public void Insert(T value)
        {
            if(PrevNode is not null)
            {
                PrevNode.Insert(value);
                return;
            }

            PrevNode = new Node<T>() { Value = value };
        }
    }
}
