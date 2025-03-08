using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            double realPart = c1.Real + c2.Real;
            double imaginaryPart = c1.Imaginary + c2.Imaginary;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public override string ToString()
        {
            return $"{Real} + {Imaginary}i";
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter details for the first complex number:");

            Console.Write("Enter real part: ");
            double real1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter imaginary part: ");
            double imaginary1 = Convert.ToDouble(Console.ReadLine());

            ComplexNumber complex1 = new ComplexNumber(real1, imaginary1);

            Console.WriteLine("\nEnter details for the second complex number:");

            Console.Write("Enter real part: ");
            double real2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter imaginary part: ");
            double imaginary2 = Convert.ToDouble(Console.ReadLine());

            ComplexNumber complex2 = new ComplexNumber(real2, imaginary2);

            ComplexNumber result = complex1 + complex2;

            Console.WriteLine($"\nSum of the two complex numbers: {result}");
        }
    }
}
