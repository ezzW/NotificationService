namespace NotificationsService
{
    public interface INotificationProvider
    {
        Notification Send(NotificationInput input);
    }
}
