// Example usage
using NotificationsService;

INotificationProvider emailProvider = new EmailNotificationProvider();
INotificationProvider pushProvider = new PushNotificationProvider();
INotificationProvider smsProvider = new SMSNotificationProvider();

NotificationService emailService = new NotificationService(emailProvider);
NotificationService pushService = new NotificationService(pushProvider);
NotificationService smsService = new NotificationService(smsProvider);

NotificationInput Emailinput = new NotificationInput() { Target = "example@email.com", Message = "Breaking news alert!" };
NotificationInput SMSinput = new NotificationInput() { Target = "00201067628592", Message = "Breaking news alert!" };
NotificationInput Pushinput = new NotificationInput() { Target = "1fd4f-2d5df-54f6y-gh5656", Message = "Breaking news alert!" };


Notification emailNotification = emailService.Send(Emailinput);
Notification pushNotification = pushService.Send(Pushinput);
Notification smsNotification = smsService.Send(SMSinput);


