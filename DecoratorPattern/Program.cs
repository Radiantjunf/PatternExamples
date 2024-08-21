namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            NotificationService service = new NotificationService(notifier);

            // Send email only
            service.SendNotification("Hello, World!", false, false);

            // Send email and SMS
            service.SendNotification("Hello, World!", true, false);

            // Send email, SMS, and push notification
            service.SendNotification("Hello, World!", true, true);
        }
    }
}
