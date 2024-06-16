using FactoryExample.Abscraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Entities
{
    public class SmsNotification : INotification
    {
        public string PhoneNumber { get; set; }

        public SmsNotification(string phoneNumber) 
        { 
            PhoneNumber = phoneNumber;
        }
        public string Send(string message)
        {
            return $"SMS sent to {PhoneNumber}: {message}";
        }
    }
}
