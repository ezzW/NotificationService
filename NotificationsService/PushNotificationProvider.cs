using Microsoft.Azure.NotificationHubs;

namespace NotificationsService
{

    public class PushNotificationProvider : NotificationProvider
    {
        public override Notification Send(NotificationInput input)
        {
            // Set up the Notification Hub client
            NotificationHubClient client = NotificationHubClient.CreateClientFromConnectionString("connection string", "hub name");

            // Set up the notification message
            Dictionary<string, string> data = new Dictionary<string, string>
        {
            { "message", input.Message }
        };

            // Send the push notification
            client.SendTemplateNotificationAsync(data, input.Target).Wait();

            // Return the notification
            return base.Send(input);
        }
    }

}
