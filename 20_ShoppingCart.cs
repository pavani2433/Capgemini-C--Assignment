using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double total);
    }

    public class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double total) => total;
    }

    public class PercentageDiscount : IDiscountStrategy
    {
        private double percentage;
        public PercentageDiscount(double percentage) => this.percentage = percentage;
        public double ApplyDiscount(double total) => total * (1 - percentage / 100);
    }

    public class FixedAmountDiscount : IDiscountStrategy
    {
        private double amount;
        public FixedAmountDiscount(double amount) => this.amount = amount;
        public double ApplyDiscount(double total) => Math.Max(0, total - amount);
    }

    public class ShoppingCart
    {
        private IDiscountStrategy discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy strategy)
        {
            discountStrategy = strategy;
        }

        public double CalculateTotal(double total)
        {
            return discountStrategy.ApplyDiscount(total);
        }
    }

    class Program
    {
        static void Main()
        {
            ShoppingCart cart = new ShoppingCart();

            Console.Write("Enter total amount: ");
            double total = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("1. No Discount");
            Console.WriteLine("2. Percentage Discount");
            Console.WriteLine("3. Fixed Amount Discount");
            Console.Write("Choose discount type: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 2)
            {
                Console.Write("Enter discount percentage: ");
                double percentage = Convert.ToDouble(Console.ReadLine());
                cart.SetDiscountStrategy(new PercentageDiscount(percentage));
            }
            else if (choice == 3)
            {
                Console.Write("Enter discount amount: ");
                double amount = Convert.ToDouble(Console.ReadLine());
                cart.SetDiscountStrategy(new FixedAmountDiscount(amount));
            }
            else
            {
                cart.SetDiscountStrategy(new NoDiscount());
            }

            double finalPrice = cart.CalculateTotal(total);
            Console.WriteLine($"Final price after discount: {finalPrice}");
        }
    }
}
