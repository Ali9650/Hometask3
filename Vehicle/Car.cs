
namespace Vehicle
{
    internal class Car : Vehicle
    {
        public int Passengers { get; set; }
        
        public Car (string  name, string color, string model,int motorHecmi, int maxSpeed, int fuelCapacity, int passengers): base (name, model, color,motorHecmi, maxSpeed, fuelCapacity)
        {
            Passengers=passengers;
        }
        public override string GetDetails()
        {
           return $"{Name} {Model} {Color} {Passengers}";
        }
    }
}
