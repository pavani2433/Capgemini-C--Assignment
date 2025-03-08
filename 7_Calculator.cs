using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            int sum1 = calculator.Add(10, 20);
            Console.WriteLine("Sum of two integers: " + sum1);

            int sum2 = calculator.Add(10, 20, 30);
            Console.WriteLine("Sum of three integers: " + sum2);

            double sum3 = calculator.Add(10.5, 20.3);
            Console.WriteLine("Sum of two doubles: " + sum3);
        }
    }
}
