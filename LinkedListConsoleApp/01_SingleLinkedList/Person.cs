namespace _01_SingleLinkedList
{

    /// <summary>
    /// Represents a person with Age x
    /// </summary>
    internal class Person
    {
        /// <summary>
        /// The Age of a people
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Returns a string with the peron age.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Person Age: " + Age;
        }

    }
}
