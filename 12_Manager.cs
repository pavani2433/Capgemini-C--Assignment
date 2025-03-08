using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class Manager
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Manager(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class Department
    {
        public string DepartmentName { get; set; }
        public Manager Manager { get; set; }

        public Department(string departmentName, Manager manager)
        {
            DepartmentName = departmentName;
            Manager = manager;
        }

        public Department ShallowCopy()
        {
            return (Department)this.MemberwiseClone();
        }

        public Department DeepCopy()
        {
            Manager newManager = new Manager(Manager.Name, Manager.Age);
            return new Department(DepartmentName, newManager);
        }

        public void Display()
        {
            Console.WriteLine($"Department: {DepartmentName}, Manager: {Manager.Name}, Age: {Manager.Age}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter Department Name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter Manager Name: ");
            string managerName = Console.ReadLine();

            Console.WriteLine("Enter Manager Age: ");
            int managerAge = Convert.ToInt32(Console.ReadLine());

            Manager manager = new Manager(managerName, managerAge);
            Department department = new Department(deptName, manager);

            Department shallowCopyDept = department.ShallowCopy();
            Console.WriteLine("\nOriginal Department:");
            department.Display();
            Console.WriteLine("\nShallow Copied Department:");
            shallowCopyDept.Display();

            shallowCopyDept.Manager.Name = "New Manager";
            Console.WriteLine("\nAfter modifying Shallow Copied Manager Name:");
            Console.WriteLine("Original Department:");
            department.Display();
            Console.WriteLine("Shallow Copied Department:");
            shallowCopyDept.Display();


            Department deepCopyDept = department.DeepCopy();
            Console.WriteLine("\nOriginal Department:");
            department.Display();
            Console.WriteLine("\nDeep Copied Department:");
            deepCopyDept.Display();

            deepCopyDept.Manager.Name = "Deep Copy Manager";
            Console.WriteLine("\nAfter modifying Deep Copied Manager Name:");
            Console.WriteLine("Original Department:");
            department.Display();
            Console.WriteLine("Deep Copied Department:");
            deepCopyDept.Display();
        }
    }
}