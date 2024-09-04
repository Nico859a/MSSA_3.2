using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(4);
            Circle circle2 = new Circle(3);

            double areaDifference = circle1 - circle2;
            double areaSum = circle1 + circle2;

            Console.WriteLine($"The area of circle 1 is: {circle1.Area()}");
            Console.WriteLine($"The area of circle 2 is: {circle2.Area()}");
            Console.WriteLine($"The difference of the two areas is: {areaDifference}");
            Console.WriteLine($"The sum of the two areas is: {areaSum}");
        }
    }

    internal class Circle
    {
            public double Radius
            { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public static double operator +(Circle circle1, Circle circle2)
        {
            return circle1.Area() + circle2.Area();
        }

        public static double operator -(Circle circle1, Circle circle2)
        {
            return circle1.Area() - circle2.Area();
        }
    }
}
