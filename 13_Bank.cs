using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class Bank
    {
        public static double InterestRate { get; set; }

        public static void SetInterestRate(double rate)
        {
            InterestRate = rate;
        }

        public void DisplayInterestRate()
        {
            Console.WriteLine($"Interest Rate for this bank: {InterestRate}%");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the bank's interest rate: ");
            double interestRate = Convert.ToDouble(Console.ReadLine());

            Bank.SetInterestRate(interestRate);

            Bank bank1 = new Bank();
            Bank bank2 = new Bank();
            Bank bank3 = new Bank();

            Console.WriteLine("\nDisplaying Interest Rate for each bank object:");
            bank1.DisplayInterestRate();
            bank2.DisplayInterestRate();
            bank3.DisplayInterestRate();

            Console.Write("\nEnter a new interest rate: ");
            interestRate = Convert.ToDouble(Console.ReadLine());
            Bank.SetInterestRate(interestRate);

            Console.WriteLine("\nDisplaying updated Interest Rate for each bank object:");
            bank1.DisplayInterestRate();
            bank2.DisplayInterestRate();
            bank3.DisplayInterestRate();
        }
    }
}
