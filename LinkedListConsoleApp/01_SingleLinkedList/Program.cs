﻿namespace _01_SingleLinkedList
{
    internal class Program
    {
        private static string name = "Hans";
        private static int listItemsToGenerate = 10;
        static void Main(string[] args)
        {

            //Test with strings values
            Console.WriteLine("List with string");
            SingleLinkedList<string> linkedListString = new SingleLinkedList<string>(name);

            for (int i = 0; i < listItemsToGenerate; i++)
            {
                linkedListString.AddItem(name + " " + i);
            }

            linkedListString.PrintAllItems();

            //Test with int values
            Console.WriteLine();
            Console.WriteLine("List with int");
            SingleLinkedList<int> linkedListInt = new SingleLinkedList<int>(0);

            Random random;
            for (int i = 0; i < listItemsToGenerate; i++)
            {
                random = new Random();
                linkedListInt.AddItem(random.Next(1, 100));
            }

            linkedListInt.PrintAllItems();

        }
    }
}
