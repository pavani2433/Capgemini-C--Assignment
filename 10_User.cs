using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }
 
        public virtual void AccessControl()
        {
            Console.WriteLine("Access Denied: No permissions assigned.");
        }
    } 

    public class Admin : User 
    {
        public Admin(string username)
        {
            Username = username;
            Role = "Admin";
        }

        public override void AccessControl()
        {
            Console.WriteLine("Access granted to all features.");
        }
    }

    public class Customer : User
    {
        public Customer(string username)
        {
            Username = username;
            Role = "Customer";
        }

        public override void AccessControl()
        {
            Console.WriteLine("Access granted to basic features.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter your role (Admin/Customer): ");
            string role = Console.ReadLine().ToLower();

            User user;

            if (role == "admin")
            {
                user = new Admin(username);
            }
            else if (role == "customer")
            {
                user = new Customer(username);
            }
            else
            {
                Console.WriteLine("Invalid role. Defaulting to Customer.");
                user = new Customer(username);
            }

            Console.WriteLine($"Welcome, {user.Username}!");
            Console.WriteLine($"Role: {user.Role}");

            user.AccessControl();
        }
    }
}
