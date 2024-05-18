
using System.Collections.Generic;

namespace Products
{
    internal class Order
    {
        private Product[] products;
        public Product[] Products { get => products; }

        public int Limit { get; } = 10;

        public Order()
        {
            products = new Product[0];
        }
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            if (Limit >= products.Length)
            {
                products[products.Length - 1] = product;
            }
            else
            {
                Console.WriteLine("Sifarisiniz maksimum mehsul sayindadir");
            }
        }

        public void RemoveProduct(Product product)
        {
            var index = Array.IndexOf(products, product);
            if (index != -1)
            {
                for (int i = index + 1; i < products.Length; i++)
                {
                    products[i - 1] = products[i];
                }
                products[products.Length - 1] = null;
                Array.Resize(ref products, products.Length - 1);
            }
            else
            {
                Console.WriteLine("Bu mehsul sifarisde yoxdu");
            }
        }
        public void GetDetails()
        {
            if (products is not null)
            {
                foreach (Product pr in products)
                {
                    Console.WriteLine($"{pr.Name} {pr.Amount} {pr.Number}");
                }
            }
        }
        public void GetTotalAmount()
        {
            double sum = 0;
            foreach (var product in Products)
            {
                sum += product.Amount;
            }
            Console.WriteLine(sum);
        }

        
       
    }
}

