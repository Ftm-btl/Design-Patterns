using FactoryExample.Abscraction;
using FactoryExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Factories
{
    public class EmailNotificationFactory : INotificationFactory
    {
        
        public INotification CreateNotification()
        {
           return new EmailNotification("fbcgame241@gmail.com");
        }
    }
}
