namespace DecoratorPatternSolved
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Base email notifier
            INotifier notifier = new EmailNotifier();
            notifier.Notify("Hello, World!");

            // Add SMS notification
            notifier = new SmsNotifierDecorator(notifier);
            notifier.Notify("Hello, World!");

            // Add push notification
            notifier = new PushNotifierDecorator(notifier);
            notifier.Notify("Hello, World!");
        }
    }
}
