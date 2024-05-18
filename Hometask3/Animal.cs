

namespace Hometask3
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public string Breed { get; set; }

        public int Age { get; set; }

        public Animal(string name, string color, string breed, int age)
        {
            Name = name;
            Color = color;
            Breed = breed;
            Age = age;
        }
        public abstract string MakeSound();
        
    }
}
