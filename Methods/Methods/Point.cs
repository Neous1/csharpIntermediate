﻿using System;

namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        //move our point to differenet location
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(Point newLocation)
        {
            if(newLocation == null)
                throw new ArgumentException("newLocation");
            //avoid duplicating , setting up X and Y
            Move(newLocation.X, newLocation.Y);
        }
    }
}