namespace SmartRefridgerator
{
    public class EmailNotifier : IEmailNotifier
    {
        public string Subject => "order groceries";

        public string Message => "order groceries from amazon";
        public string SendNotification()
        {
            return "Notification send through Email";
        }
    }
}
