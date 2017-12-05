using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Canvas
    {
        public void Drawshapes(List<Shape> shapes)
        {
            // polymorphism
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        { 
        }
    }
}
