using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    public interface INotificationObserver
    {
        void Update(string message);
    }

    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Email Notification: " + message);
        }
    }

    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }
    }

    public class NotificationService
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();

        public void Subscribe(INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public void Unsubscribe(INotificationObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            NotificationService service = new NotificationService();

            INotificationObserver emailNotifier = new EmailNotifier();
            INotificationObserver smsNotifier = new SMSNotifier();

            service.Subscribe(emailNotifier);
            service.Subscribe(smsNotifier);

            Console.Write("Enter a notification message: ");
            string message = Console.ReadLine();

            service.Notify(message);
        }
    }
}
