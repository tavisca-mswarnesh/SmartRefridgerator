namespace SmartRefridgerator
{
    public class SmsNotifier : INotifier
    {
        public string Message => "order groceries";
        public string SendNotification()
        {
            return "Notification send through SMS";
        }
    }
}
