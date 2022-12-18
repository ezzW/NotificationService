namespace NotificationsService
{
    public class NotificationService
    {
        private INotificationProvider _notificationProvider;

        public NotificationService(INotificationProvider notificationProvider)
        {
            _notificationProvider = notificationProvider;
        }

        public Notification Send(NotificationInput input)
        {
            return _notificationProvider.Send(input);
        }
    }
}
