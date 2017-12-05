using System.Collections.Generic;

namespace MethodOverriding
{
    public class Canvas
    {
        public void Drawshapes(List<Shape> shapes)
        {
            // polymorphism (one draw call to draw them all)
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}