using System;

namespace DesignPattern.Facade.ShapeExample.Shapes
{
    public class Circle
    {
        private double radius;
        private const double PI = 3.14;

        public void Draw()
        {
            Console.WriteLine("Circle: Draw()");
        }

        public double CalculateDiameter()
        {
            return 2 * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * PI * radius;
        }

        public double CalculateArea()
        {
            return PI * radius * radius;
        }
    }
}
