using System;

namespace Area
{
    internal class Circle
    {
        public void area(float r)
        {
            float area = (float)3.14 * r * r;
            Console.WriteLine("Area of Circle is: " + area);
        }
    }

    internal class Rectangle : Circle
    {
        public void area(float l, float b)
        {
            float area = (float)l * b;
            Console.WriteLine("Area of Rectangle is: " + area);
        }
    }

    internal class Square : Rectangle
    {
        public void area(float s)
        {
            float area = (float)s * s;
            Console.WriteLine("Area of Square is: " + area);
        }
    }

    internal class Program : Square
    {
        private static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            Square s = new Square();
            Console.WriteLine("Raj Chhadia");
            Console.WriteLine("Enter the radius of circle: ");
            c.area(float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the Length and breadth of Rectangle: ");
            r.area(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the side of square: ");
            s.area(float.Parse(Console.ReadLine()));
            Console.Read();
        }
    }
}