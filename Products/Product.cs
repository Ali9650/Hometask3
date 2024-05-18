

namespace Products
{
    internal class Product
    {

        public  Product (string name, double amount, int number)
        {
            Name = name;
            Amount = amount;
            Number = number;
        }
 
        public string Name { get; set; }

        public double Amount { get; set; }
        public int amount { get; internal set; }
        public int Number {  get; set; }

        
    }
    

}
