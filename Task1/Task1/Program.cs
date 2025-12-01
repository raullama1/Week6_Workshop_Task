using System;

namespace Task1
{
    public class Program
    {
        public static void Main()
        {
            // Create a rectangle object
            Rectangle rect = new Rectangle();
            rect.Length = 10;
            rect.Breadth = 5;

            // Display rectangle details
            Console.WriteLine(rect.ShowDetails());
            Console.WriteLine("Area: " + rect.GetArea());
            Console.WriteLine("Perimeter: " + rect.GetPerimeter());
        }
    }
}