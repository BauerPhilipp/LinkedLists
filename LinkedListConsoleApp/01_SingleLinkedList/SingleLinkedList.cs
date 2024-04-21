using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_SingleLinkedList
{
    internal class SingleLinkedList<T>
    {  


        // Stores the last AddedItem
        private Node<T> _rootNode;

        // Stores the first AddedItem;
        private Node<T> _lastNode;

        /// <summary>
        /// Allows to create a new list without items
        /// </summary>
        public SingleLinkedList()
        {
        }

        /// <summary>
        /// Initialise linkedList and add first item
        /// </summary>
        /// <param name="value"></param>
        public SingleLinkedList(T value) 
        {
            _rootNode = new Node<T> { Value = value};
            _lastNode = _rootNode;
        }

        /// <summary>
        /// Add an item to the list
        /// </summary>
        /// <param name="value"></param>
        public void AddItem(T value)
        {
            if (_rootNode is null)
            {
                _rootNode = new Node<T> { Value = value };
                _lastNode = _rootNode;
                return;
            }

            Node<T> newNode = new Node<T> { Value = value };
            newNode.NextNode = _rootNode;
            _rootNode = newNode;
        }

        /// <summary>
        /// Print all items to the console
        /// </summary>
        public void PrintAllItems()
        {

            int counter = 0;
            Node<T> currentNode = _rootNode;

            while (currentNode is not null)
            {
                Console.WriteLine(currentNode);
                currentNode = currentNode.NextNode; 
                counter++;
            }
            Console.WriteLine($"Total items in SingleLinkedList: {counter}");
        }

        public void PrintAllItemsReverse()
        {
            Node<T> currentNode = _rootNode;
            int counter = -1;

            while (currentNode is not null)
            {
                currentNode = currentNode.NextNode;
                counter++;
            }
            while (currentNode != _rootNode)
            {
                currentNode = _rootNode;
                for (int i = counter; i > 0; i--)
                {
                    currentNode = currentNode.NextNode;
                }
    
                Console.WriteLine(currentNode);
                counter--;
                if(counter < 0) { currentNode = _rootNode; }
            }        
        }
    }

}
