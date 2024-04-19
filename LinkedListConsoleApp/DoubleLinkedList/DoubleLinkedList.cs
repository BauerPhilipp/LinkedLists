using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    /// <summary>
    /// LinkedList to store items in nodes.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class DoubleLinkedList<T>
    {
        DoubleLinkedNode<T> _rootNode;

        /// <summary>
        /// Add item to the list
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (_rootNode is null)
            {
                _rootNode = new DoubleLinkedNode<T> { Data = item};
                return;
            }

            _rootNode.Insert(item);

        }

        /// <summary>
        /// Print all items in this list
        /// </summary>
        public void PrintAll()
        {
            try
            {
                DoubleLinkedNode<T> currentNode = _rootNode;

                // If it is a list of animals
                if (currentNode.Data is Animal)
                {
                    PrintAnimals();
                    return;
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A normal list");
                Console.ResetColor();
                while (currentNode is not null)
                {
                    Console.Write($"CurrentNode: {currentNode.Data} ");
                    if (currentNode.NextNode is not null) Console.Write($", NextNode: {currentNode.NextNode.Data} ");
                    if (currentNode.PrevNode is not null) Console.Write($", PrevNode: {currentNode.PrevNode.Data} ");
                    Console.WriteLine();
                    currentNode = currentNode.NextNode;
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("!List load failure!");
                Console.WriteLine("No items in this list?");
                Console.ResetColor();
            }
            
        }

        private void PrintAnimals()
        {
            DoubleLinkedNode<T> currentNode = _rootNode;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This list is full of animals:");
            Console.ResetColor();
            while (currentNode is not null)
            {
                Console.Write($"CurrentNode: {currentNode.Data}, ");
                Console.WriteLine("Legs count: " + (currentNode.Data as Animal).Legs);
                if (currentNode.NextNode is not null) Console.Write($"   NextNode: {currentNode.NextNode.Data} ");
                if (currentNode.PrevNode is not null) Console.Write($"   PrevNode: {currentNode.PrevNode.Data} ");
                Console.WriteLine("\n");

                currentNode = currentNode.NextNode;
            }
        }
    }
}
