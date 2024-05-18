namespace Vehicle
{
    public class Program
    {
        static void Main()
        {
            Car car = new Car("Merseders", "qara", "sedan", 2, 200, 50, 5 );
            Console.WriteLine (car.GetDetails());

            Truck truck = new Truck("Daewoo", "boz", "truck", 2, 200, 200,300);
            Console.WriteLine(truck.GetDetails());
        }
    }
}