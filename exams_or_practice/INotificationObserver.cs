using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    public interface INotificationObserver
    {
        void Update(string message);
    }

    // EmailNotifier.cs
    public class EmailNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }

    // SMSNotifier.cs
    public class SMSNotifier : INotificationObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }

    // NotificationService.cs
    public class NotificationService
    {
        private List<INotificationObserver> observers = new List<INotificationObserver>();

        public void AddObserver(INotificationObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(INotificationObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }

}
