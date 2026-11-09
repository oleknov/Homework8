using System;

namespace Exercise3
{
    abstract class Shape
    {
        public abstract int GetArea();
    }

    class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int GetArea()
        {
            return Width * Height;
        }
    }

    class Square : Shape
    {
        public int Side { get; set; }

        public override int GetArea()
        {
            return Side * Side;
        }
    }

    static class Demo
    {
        public static void Run()
        {
            Shape rect = new Rectangle() { Width = 5, Height = 10 };
            Shape square = new Square() { Side = 5 };

            Console.WriteLine(rect.GetArea());
            Console.WriteLine(square.GetArea());
        }
    }
}