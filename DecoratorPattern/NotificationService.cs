using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class NotificationService
    {
        private readonly Notifier _notifier;

        public NotificationService(Notifier notifier)
        {
            _notifier = notifier;
        }

        public void SendNotification(string message, bool sendSms, bool sendPushNotification)
        {
            _notifier.Notify(message);

            if (sendSms)
            {
                SendSmsNotification(message);
            }

            if (sendPushNotification)
            {
                SendPushNotification(message);
            }
        }

        private void SendSmsNotification(string message)
        {
            Console.WriteLine("Sending SMS notification: " + message);
        }

        private void SendPushNotification(string message)
        {
            Console.WriteLine("Sending push notification: " + message);
        }
    }
}
