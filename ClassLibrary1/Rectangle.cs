using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Rectangle: Shape
    {
        public override void Drawing()
        {
            //base.Drawing();
            Console.WriteLine($"Rectangle drawing... X: {X} - Y: {Y} - Area: {CalculateArea()}");
        }
        protected override decimal CalculateArea()
        {
            return (19);
        }
    }
}
