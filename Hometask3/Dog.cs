
namespace Hometask3
{
    internal class Dog : Animal
    {
        public Dog(string name, string color, string breed, int age) : base(name, color, breed, age)
        {

        }
        public override string MakeSound()
        {
            return "Hav";
        }
    }
}