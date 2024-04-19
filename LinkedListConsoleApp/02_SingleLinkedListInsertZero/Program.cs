namespace _02_SingleLinkedListInsertZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList<int> singleLinkedListInt = new SingleLinkedList<int>();

            for (int i = 0; i < 10; i++)
            {
                singleLinkedListInt.AddItem(i);
            }

        }
    }
}
