

namespace Products
{
    internal class Electronic : Product
    {
        public string Material { get; set; }
        public Electronic(string name, double amount, int number, string material) : base(name, amount, number)
        {
            Material = material;
        }
    }
}

