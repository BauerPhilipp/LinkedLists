using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingleLinkedList
{
    internal class SingleLinkedList<T>
    {
        
        private Node<T> _lastNode;

        /// <summary>
        /// Initialise linkedList and add first item
        /// </summary>
        /// <param name="value"></param>
        public SingleLinkedList(T value) 
        {
            _lastNode = new Node<T> { Value = value};
        }

        /// <summary>
        /// Add an item
        /// </summary>
        /// <param name="value"></param>
        public void AddItem(T value)
        {
            _lastNode.Insert(value);
        }

        /// <summary>
        /// Print all items to the console
        /// </summary>
        public void PrintAllItems()
        {

            int counter = 0;
            Node<T> currentNode = _lastNode;
            if(currentNode.Value is Person person)
            {
                while (currentNode is not null)
                {
                    Person p = currentNode.Value as Person;
                    Console.WriteLine($"Age of Person: {p.Age}");
                    currentNode = currentNode.PrevNode;
                    counter++;
                }
            }

            while (currentNode is not null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.PrevNode; 
                counter++;
            }
            Console.WriteLine($"Total items in SingleLinkedList: {counter}");
        }

    }
}
