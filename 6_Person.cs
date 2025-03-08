using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CSharpAssignment
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    public class Studentt : Person
    {
        public string Course { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Course: {Course}");
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Subject: {Subject}");
        }
    }

    class Program
    {
        static void Main()
        {
            Person person;

            Console.WriteLine("Enter Student Details:");
            Studentt student = new Studentt();

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            student.Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            student.Course = Console.ReadLine();

            person = student;
            Console.WriteLine("\nStudent Details:");
            person.GetDetails();

            Console.WriteLine("\nEnter Teacher Details:");
            Teacher teacher = new Teacher();
            Console.Write("Enter Name: ");
            teacher.Name = Console.ReadLine();
            Console.Write("Enter Age: ");
            teacher.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Subject: ");
            teacher.Subject = Console.ReadLine();

            person = teacher;
            Console.WriteLine("\nTeacher Details:");
            person.GetDetails();
        }
    }
}
