using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class BankAccount
    {
        private int balance = 1000;
        public void Deposit(int Depositamount)
        {
            balance += Depositamount;
            Console.WriteLine("Amount deposited successfully");
            Console.WriteLine("Balance after deposite is " + balance);
        }
        public void Withdraw(int Withdrawamount)
        {
            if (balance < Withdrawamount)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                balance -= Withdrawamount;
                Console.WriteLine("Amount withdrawn successfully");
                Console.WriteLine("Balance after withdraw is " + balance);
            }
        }
        public void DisplayAmount()
        {
            Console.WriteLine("Balance is " + balance);
        }
        public static void Main(String[] args)
        {
            BankAccount bankaccount = new BankAccount();
            bankaccount.DisplayAmount();
            Console.WriteLine("Enter the Depsoit amount");
            int Depositamount = Convert.ToInt32(Console.ReadLine());
            bankaccount.Deposit(Depositamount);

            Console.WriteLine("Enter the Withdraw amount");
            int Withdrawamount = Convert.ToInt32(Console.ReadLine());
            bankaccount.Withdraw(Withdrawamount);

        }

    }
}
