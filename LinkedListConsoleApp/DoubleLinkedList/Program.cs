namespace DoubleLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<float> listOfFloats = new DoubleLinkedList<float>();
            listOfFloats.PrintAll();

            // Test with int
            DoubleLinkedList<int> listOfInt = new DoubleLinkedList<int>();
            listOfInt.Add(1); 
            listOfInt.Add(2);
            listOfInt.Add(3);
            listOfInt.PrintAll();

            // Test with Animal
            DoubleLinkedList<Animal> listOfAnimal = new DoubleLinkedList<Animal>();
            listOfAnimal.Add(new Spider(8));
            listOfAnimal.Add(new Ant(6));
            listOfAnimal.Add(new Spider(7));
            listOfAnimal.Add(new Ant(9));
            listOfAnimal.Add(new Spider(10));
            listOfAnimal.Add(new Ant(3));

            listOfAnimal.PrintAll();


        }
    }
}
