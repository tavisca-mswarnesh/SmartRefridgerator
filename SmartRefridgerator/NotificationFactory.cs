namespace SmartRefridgerator
{
    public class NotificationFactory
    {
        string notifiacationType;
        VegetableTracker vegetableTracker;
        public NotificationFactory(string notifiacationType,VegetableTracker vegetableTracker)
        {
            this.vegetableTracker = vegetableTracker;
            this.notifiacationType = notifiacationType;
        }
        public INotifier GetNotifier()
        {
            switch (notifiacationType)
            {
                case "SmsNotifier":
                    return new SmsNotifier();
                case "EmailNotifier":
                    return new EmailNotifier();
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}
