using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class SecuritySystem
    {
        public string SystemName { get; set; }
        public string SecurityLevel { get; set; }

        public SecuritySystem(string systemName, string securityLevel)
        {
            SystemName = systemName;
            SecurityLevel = securityLevel;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Security System: {SystemName}");
            Console.WriteLine($"Security Level: {SecurityLevel}");
        }
    }


    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Security System Details:");
            Console.Write("Enter System Name: ");
            string systemName = Console.ReadLine();

            Console.Write("Enter Security Level (e.g., High, Medium, Low): ");
            string securityLevel = Console.ReadLine();

            SecuritySystem securitySystem = new SecuritySystem(systemName, securityLevel);

            Console.WriteLine("\nSecurity System Details:");
            securitySystem.DisplayDetails();
        }
    }
}
