

namespace Shapess
{
    internal class Trinagle: Shape
    {
        public int Height { get; set; }

        public int Side { get; set; }

        public Trinagle (int height, int side)
        {
            Height = height;
            Side = side;
        }

        public override void FindArea()
        {
            Area = 0.5 * Height * Side;
            Console.WriteLine($"Trinagle {Area}");
        }
    }
}
