using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternSolved
{
    public class PushNotifierDecorator : INotifier
    {
        private readonly INotifier _wrappedNotifier;

        public PushNotifierDecorator(INotifier notifier)
        {
            _wrappedNotifier = notifier;
        }

        public void Notify(string message)
        {
            _wrappedNotifier.Notify(message);
            SendPushNotification(message);
        }

        private void SendPushNotification(string message)
        {
            Console.WriteLine("Sending push notification: " + message);
        }
    }
}
