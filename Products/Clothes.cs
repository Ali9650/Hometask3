

namespace Products
{
    internal class Clothes : Product
    {
        public string Size { get; set; }
        public Clothes(string name, double amount, int number,string size) : base(name, amount, number)
        {
            Size = size;
        }
    }
}