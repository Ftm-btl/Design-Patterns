﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExample.Abscraction
{
    public interface INotification
    {
        string Send(string message);
    }
}
