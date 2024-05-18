

using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Shapess
{
    internal class Circle :Shape
    {
        public int Radius { get; set; } 

        public Circle (int radius)
        {
            Radius = radius;
        }
        public override void FindArea()
        {
            Area=Math.Round(Math.PI,2)*(Radius*Radius);
            Console.WriteLine($"Circle {Area}");

            
        }
    }
}
