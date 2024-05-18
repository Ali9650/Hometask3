
namespace Vehicle
{
        internal class Truck : Vehicle
        {
            public int Load { get; set; }

            public Truck(string name, string color, string model, int motorHecmi, int maxSpeed, int fuelCapacity, int load) : base(name, model, color, motorHecmi, maxSpeed, fuelCapacity)
            {
                Load = load;
            }
            public override string GetDetails()
            {
                return $"{Name} {Model} {Color} {Load}";
            }
        }


    }
