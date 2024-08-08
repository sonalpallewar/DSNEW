using System;

namespace Shapes
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

namespace ProgramNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Shapes.Circle circle = new Shapes.Circle(5.0);
            Console.WriteLine("Area of the circle: " + circle.GetArea());
        }
    }
}
