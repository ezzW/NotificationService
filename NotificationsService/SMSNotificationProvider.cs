using System.Net;
using System.Text;

namespace NotificationsService
{
    public class SMSNotificationProvider : NotificationProvider
    {
        public override Notification Send(NotificationInput input)
        {
            // Set up the request parameters
            string apiUrl = "https://www.mobily.ws/api/msgSend.php";
            string apiUsername = "username";
            string apiPassword = "password";
            string sender = "sender";
            string recipients = input.Target;
            string message = input.Message;
            string unicode = "E"; // Set to "E" for Unicode (Arabic) messages, or "0" for ASCII messages

            // Build the request query string
            StringBuilder queryString = new StringBuilder();
            queryString.Append($"apiKey={apiUsername}");
            queryString.Append($"&apiPassword={apiPassword}");
            queryString.Append($"&numbers={recipients}");
            queryString.Append($"&sender={sender}");
            queryString.Append($"&msg={message}");
            queryString.Append($"&unicode={unicode}");

            // Set up the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] data = Encoding.UTF8.GetBytes(queryString.ToString());
            request.ContentLength = data.Length;

            // Send the request
            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            // Get the response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // Return the notification
            return base.Send(input);
        }
    }
}
