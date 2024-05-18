namespace Hometask3
{
    internal class Program
    {
        static void Main()
        {
            Cat cat = new Cat("Mesi", "Black", "kedi", 5);
            Console.WriteLine($"Mesi {cat.MakeSound()}");

            Dog dog = new Dog("Toplan", "White", "it", 3);
            Console.WriteLine($"Toplan {dog.MakeSound()}");
        }
    }
}
