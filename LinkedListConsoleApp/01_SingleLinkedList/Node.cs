using System.Collections.Generic;

namespace _01_SingleLinkedList
{
    /// <summary>
    /// Node for storing the Item
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

        public Node<T> NextNode { get; set; }


        /// <summary>
        /// Returns Value.ToString();
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Value.ToString();
        }

    }
}
