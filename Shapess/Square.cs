using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapess
{
    internal class Square :Shape
    {
        public int Side { get; set; }

        public Square(int side) 
        {
            Side = side;
        }
        public override void FindArea()
        {
            Area= Side * Side;
            Console.WriteLine($"Square {Area}");
        }
        
    }
}
