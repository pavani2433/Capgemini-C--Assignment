using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return 3.14 * radius * radius;
        }
    }
    class Rectangle : Shape
    {
        private double length, width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double CalculateArea()
        {
            return length * width;
        }



        static void Main()
        {
            Console.Write("Enter the radius of the circle: ");
            double circleRadius = Convert.ToDouble(Console.ReadLine());
            Shape circle = new Circle(circleRadius);

            Console.Write("Enter the length of the rectangle: ");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width of the rectangle: ");
            double rectangleWidth = Convert.ToDouble(Console.ReadLine());
            Shape rectangle = new Rectangle(rectangleLength, rectangleWidth);

            Console.WriteLine("\nArea of Circle: " + circle.CalculateArea());
            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
        }
    }
    
    }
