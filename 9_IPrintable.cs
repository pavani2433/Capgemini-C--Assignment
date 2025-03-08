using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    interface IPrintable
    {
        void Print();
    }
    public interface ISerializable
    {
        void SaveToFile(string filename);
    }
    public class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public void Print()
        {
            Console.WriteLine("Printing Report:");
            Console.WriteLine($"Title: {Title}\nContent: {Content}");
        }
        public void SaveToFile(string filename)
        {
            File.WriteAllText(filename, $"Title: {Title}\nContent: {Content}");
            Console.WriteLine($"Report Saved to file: {filename}");
        }
    }
    class Program
    {
        static void Main()
        {
            Report report = new Report();

            Console.WriteLine("Enter Report Details:");

            Console.Write("Enter Report Title: ");
            report.Title = Console.ReadLine();

            Console.Write("Enter Report Content: ");
            report.Content = Console.ReadLine();

            Console.WriteLine("\nDemonstrating Interface Methods:");

            IPrintable printableReport = report;
            printableReport.Print();

            Console.WriteLine("\nEnter file name to save report:");
            string filename = Console.ReadLine();

            ISerializable serializableReport = report;
            serializableReport.SaveToFile(filename);
        }
    }
}
