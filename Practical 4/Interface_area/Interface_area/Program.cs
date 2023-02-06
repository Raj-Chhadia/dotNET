namespace Interface_area
{
    using System;

    internal interface Area
    {
        void area();
    }

    internal class Square : Area
    {
        private float side;

        public Square(float side)
        {
            this.side = side;
            this.area();
        }

        public void area()
        {
            Console.WriteLine("Area of sqaure is: " + (side * side));
        }
    }

    internal class Rectangle : Area
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

    internal class Circle : Area
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

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Area using interface");
            Console.WriteLine("Raj Chhadia");
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

            Console.Read();
        }
    }
}
