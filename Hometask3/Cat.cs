
namespace Hometask3
{
    internal class Cat : Animal
    {
        public Cat(string name, string color, string breed, int age) : base(name, color, breed, age)
        {

        }
        public override string MakeSound ()
        {
            return "Mya"; 
        }
    }
}
