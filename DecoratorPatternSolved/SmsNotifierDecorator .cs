using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternSolved
{
    public class SmsNotifierDecorator : INotifier
    {
        private readonly INotifier _wrappedNotifier;

        public SmsNotifierDecorator(INotifier notifier)
        {
            _wrappedNotifier = notifier;
        }

        public void Notify(string message)
        {
            _wrappedNotifier.Notify(message);
            SendSmsNotification(message);
        }

        private void SendSmsNotification(string message)
        {
            Console.WriteLine("Sending SMS notification: " + message);
        }
    }
}
