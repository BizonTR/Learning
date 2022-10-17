using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Triangle: Shape
    {
        public override void Drawing()
        {
            Console.WriteLine($"Triangle drawing... X: {X} - Y: {Y}");
        }
    }
}
