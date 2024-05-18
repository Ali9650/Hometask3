

namespace Vehicle
{
    internal class Vehicle
    {
        public string Name { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int MotorHecmi { get; set; }

        public int MaxSpeed { get; set; }

        public int FuelCapacity { get; set; }

        public Vehicle(string name, string model, string color, int motorHecmi, int maxSpeed, int fuelCapacity)
        {
            Name = name;
            Model = model;
            Color = color;
            MotorHecmi = motorHecmi;
            MaxSpeed = maxSpeed;
            FuelCapacity = fuelCapacity;
        }


        public virtual string GetDetails()
        {
            return $"{Name} {Model} {Color}";
        }
    }
}
