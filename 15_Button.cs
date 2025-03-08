using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public class Button
    {
        public delegate void ButtonClickHandler(string message);

        public event ButtonClickHandler OnClick;

        public void Click(string message)
        {
            OnClick?.Invoke(message);
        }
    }

    class Program
    {
        static void Main()
        {
            Button button = new Button();

            button.OnClick += Button_Click;

            Console.WriteLine("Enter a message to simulate button click: ");
            string message = Console.ReadLine();

            button.Click(message);
        }

        private static void Button_Click(string message)
        {
            Console.WriteLine($"Button clicked! Message: {message}");
        }
    }
}
