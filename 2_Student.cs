
//**Data Hiding with Properties**
//Create a `Student` class where `Name` and `RollNo` are private fields.Use properties to enforce validation (e.g., `RollNo` cannot be negative, `Name` cannot be empty).

using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{

    class Student
    {
        private string name;
        private int rollNo;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty or whitespace.");
                name = value;
            }
        }

        public int RollNo
        {
            get { return rollNo; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Roll Number cannot be negative.");
                rollNo = value;
            }
        }

        public Student(string name, int rollNo)
        {
            Name = name;   
            RollNo = rollNo;
        }

        public void Display()
        {
            Console.WriteLine($"Student Name: {Name}, Roll Number: {RollNo}");
        }

        public static void Main()
        {
            try
            {
                Student student1 = new Student("Alice", 101);
                student1.Display();

                Student student2 = new Student("", 102);

                Student student3 = new Student("Bob", -5);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}