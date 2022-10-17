using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Shape
        //eğer public class sealed Shape deseydik bu class herhangi bir class tarafından inherit edilemeyecekti.
    {
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Drawing()
        {
            Console.WriteLine($"Shape drawing... X: {X} - Y: {Y}  - Area: {CalculateArea()}");
        }

        protected virtual decimal CalculateArea()
        {
            return(55);
        }
    }
}
