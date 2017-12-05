﻿using System;

namespace MethodOverriding
{
    class Circle: Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
            
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");

        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        //virtual keyworld makes draw() overidable in other subclass
        // that need to draw as a base method
        public virtual void Draw()
        {
            
        }
    }
}