using FactoryExample.Abscraction;
using FactoryExample.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Factories.Generator
{
    public static class NotificationGenerator
    {
        public static INotification Generate(NotificationType notificationType)
        {
            INotificationFactory notificationFactory = notificationType switch
            {
                NotificationType.Email => new EmailNotificationFactory(),
                NotificationType.SMS => new SmsNotificationFactory(),
                NotificationType.Push => new PushNotificationFactory(),
                _ => throw new NotImplementedException(),
            };

            return notificationFactory.CreateNotification();
        }
    }
}
