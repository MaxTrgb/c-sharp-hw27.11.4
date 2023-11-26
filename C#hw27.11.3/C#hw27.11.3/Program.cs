namespace MySpace
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();

            person.Name = "John";
            person.Age = 25;

            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");

            person.Age = 30;

            Console.WriteLine("\nUpdated Data:");
            Console.WriteLine($"Name: {person.Name}");
            Console.WriteLine($"Age: {person.Age}");
        }
    }
}
