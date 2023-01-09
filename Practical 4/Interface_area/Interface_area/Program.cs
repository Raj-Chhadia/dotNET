using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_area
{
    interface Area
    {
        void area();
    }

    class Square : Area
    {
        private float side;

        public Square(float side)
        {
            this.side = side;
            this.area();
        }

        public void area()
        {
            Console.WriteLine("Area of sqaure is: " + (side*side));
        }
    }

    class Rectangle : Area
    {
        private float length;
        private float breadth;

        public Rectangle(float length, float breadth)
        {
            this.length = length;
            this.breadth = breadth;
            this.area();
        }

        public void area()
        {
            Console.WriteLine("Area of rectangle is: " + (length * breadth));
        }
    }

    class Circle : Area
    {
        private float radius;

        public Circle(float radius)
        {
            this.radius = radius;
            this.area();
        }

        public void area()
        {
            Console.WriteLine("Area of circle is: " + (3.14 * radius * radius));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area using interface");
            float side, length, breadth, radius;
            
            Console.WriteLine("Enter side of a square");
            side = float.Parse(Console.ReadLine());
            Square sq = new Square(side);

            Console.WriteLine("Enter length of a rectangle");
            length = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of a rectangle");
            breadth = float.Parse(Console.ReadLine());
            Rectangle rec = new Rectangle(length, breadth);

            Console.WriteLine("Enter radius of a circle");
            radius = float.Parse(Console.ReadLine());
            Circle circ = new Circle(radius);

            Console.ReadKey();
        }
    }
}
