namespace NotificationsService
{
    // Base NotificationProvider class
    public abstract class NotificationProvider : INotificationProvider
    {
        public virtual Notification Send(NotificationInput input)
        {
            // Send notification and return Notification object with generated Guid as Id
            Notification notification = new Notification() { Id = Guid.NewGuid() };
            // Perform send notification logic here
            return notification;
        }
    }
}