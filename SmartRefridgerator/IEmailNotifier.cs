namespace SmartRefridgerator
{
    public interface IEmailNotifier :INotifier
    {
         string Subject { get; }
    }
}
