namespace _01_SingleLinkedList
{
    internal class Program
    {
        /// <summary>
        /// simple placeholder
        /// </summary>
        private static string _name = "Hans";
        /// <summary>
        /// To add or reduce items in the generated list adjust the value.
        /// </summary>
        private static int _listItemsToGenerate = 10;

        static void Main(string[] args)
        {
            //Start the test case
            StartTest();
        }


        /// <summary>
        /// Functional test of different cases
        /// </summary>
        private static void StartTest()
        {

            //Test with strings values
            Console.WriteLine("List with string");
            SingleLinkedList<string> linkedListHans = new();

            for (int i = 0; i < _listItemsToGenerate; i++)
            {
                linkedListHans.AddItem(_name + " " + i);
            }

            linkedListHans.PrintAllItems();
            //linkedListHans.PrintAllItemsReverse(); // Additional test

            //Test with int values
            Console.WriteLine();
            Console.WriteLine("List with int");
            SingleLinkedList<int> linkedListNumber = new();

            Random random;
            for (int i = 0; i < _listItemsToGenerate; i++)
            {
                random = new Random();
                linkedListNumber.AddItem(random.Next(1, 100));
            }

            linkedListNumber.PrintAllItems();
            //linkedListNumber.PrintAllItemsReverse(); // Additional test

            //Test with Person
            Console.WriteLine();
            Console.WriteLine("List with Person objects");
            SingleLinkedList<Person> linkedListPeople = new(new Person() { Age = 10 });

            for (int i = 0; i < _listItemsToGenerate + 5; i++)
            {
                random = new Random();
                linkedListPeople.AddItem(new Person() { Age = random.Next(1, 99) });
            }

            linkedListPeople.PrintAllItems();
            linkedListPeople.PrintAllItemsReverse();
        }
    }
}
