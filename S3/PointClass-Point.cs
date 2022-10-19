using System;
using System.Runtime.CompilerServices;

namespace Shapes
{
    internal class Point
    {

        private int x;
        private int y;

        //A constructor 
        public Point(int xarg, int yarg)
        {
            x = xarg;
            y = yarg;
        }

        public void Display()
        {
            Console.WriteLine($"[{x}, {y}]");

        }

        public void DistanceFrom(Point p1)
        {


            double distanceFrom = Math.Sqrt(Math.Pow((p1.x - x), 2) + Math.Pow((p1.y - y), 2));
            Console.WriteLine($"The Distance between the two Points are: {distanceFrom}");

        }
    }
}

