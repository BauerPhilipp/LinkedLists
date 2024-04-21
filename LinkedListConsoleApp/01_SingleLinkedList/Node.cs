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

        /// <summary>
        /// The next node is the prev _root node
        /// </summary>

        private Node<T> _nextNode;

        public Node<T> NextNode { get; set; }



        /// <summary>
        /// Override the ToString for easy debugging
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value.ToString();
        }

    }
}
