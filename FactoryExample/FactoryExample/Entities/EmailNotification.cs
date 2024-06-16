using FactoryExample.Abscraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Entities
{
    public class EmailNotification : INotification
    {
        public string EmailAddress { get; set; }

        public EmailNotification(string emailAddress)
        {
            EmailAddress = emailAddress;
        }

        public string Send(string message)
        {
            return $"Email sent to {EmailAddress}: {message}";
        }
    }
}
