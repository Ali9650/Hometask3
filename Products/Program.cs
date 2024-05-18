namespace Products
{
    internal class Program
    {
        static void Main()
        {
          Electronic electronic = new Electronic ("Samsung", 2000, 1 , "Titan");
            Clothes clothes = new Clothes ("LC", 200, 1, "M");

            Order order = new Order();
            order.AddProduct(electronic);
            order.AddProduct(clothes);
            order.GetDetails();

           order.GetTotalAmount();
        }
    }
}
