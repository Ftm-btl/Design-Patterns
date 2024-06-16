using FactoryExample.Enums;
using FactoryExample.Factories.Generator;


System.Console.WriteLine(NotificationGenerator.Generate(NotificationType.Email).Send("Hello via Email!"));
System.Console.WriteLine(NotificationGenerator.Generate(NotificationType.SMS).Send("Hello via SMS!"));
System.Console.WriteLine(NotificationGenerator.Generate(NotificationType.Push).Send("Hello via Push Notification!"));


NotificationGenerator.Generate(NotificationType.Email);
