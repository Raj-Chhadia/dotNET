using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Circle
    {
        public void area(float r)
        {
            float area = (float) 3.14 * r * r;
            Console.WriteLine("Area of Circle is: " + area);
        }
    }
    class Rectangle : Circle
    {
        public void area(float l, float b)
        {
            float area = (float) l * b;
            Console.WriteLine("Area of Rectangle is: " + area);
        }
    }
    class Square : Rectangle
    {
        public void area(float s)
        {
            float area = (float) s * s;
            Console.WriteLine("Area of Square is: " + area);
        }
    }
    class Program : Square
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            Square s = new Square();
            Console.WriteLine("Enter the radius of circle: ");
            c.area(float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the Length and breadth of Rectangle: ");
            r.area(float.Parse(Console.ReadLine()), float.Parse(Console.ReadLine()));
            Console.WriteLine("Enter the side of square: ");
            s.area(float.Parse(Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
