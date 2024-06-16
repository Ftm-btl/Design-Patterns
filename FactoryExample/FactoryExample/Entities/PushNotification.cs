using FactoryExample.Abscraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Entities
{
    public class PushNotification : INotification
    {
        public string DeviceId { get; set; }

        public PushNotification(string deviceId)
        {
            DeviceId = deviceId;
        }
        public string Send(string message)
        {
            return $"Push notification sent to device {DeviceId}: {message}";
        }
    }
}
