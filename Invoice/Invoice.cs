

namespace Invoice
{
    internal class Invoice
    {
        public Invoice(string Account, string Customer, string Provider) 
        {
            this.Account = Account;
            this.Customer = Customer;
            this.Provider=Provider;
        }
        public string Account { get; }

        public string Customer { get; }

        public string Provider { get;}

        public  string Article { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public void CostCalculation (bool needEdv)
        {
            decimal edv=Quantity*Price*18/100;
            if (needEdv)
            {
        
                Price =(Price*Quantity)+edv;
                Console.WriteLine(Price);
            }
            else
            {
                Price=Price*Quantity;
                Console.WriteLine(Price);
            }
        }
    }

     
}
