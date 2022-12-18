using System.Net;
using System.Net.Mail;

namespace NotificationsService
{
    // EmailNotificationProvider class
    public class EmailNotificationProvider : NotificationProvider
    {
        public override Notification Send(NotificationInput input)
        {
            // Send email notification

            // Set up the email message
            MailMessage message = new MailMessage();
            message.To.Add(input.Target);
            message.Subject = "Breaking news alert!";
            message.Body = input.Message;

            // Set up the email server
            SmtpClient client = new SmtpClient();
            client.Host = "smtp.example.com";
            client.Port = 587;
            client.Credentials = new NetworkCredential("user@example.com", "password");

            // Send the email
            client.Send(message);

            // Return the notification
            return base.Send(input);
        }
    }
}
