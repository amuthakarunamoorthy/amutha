﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HelloWorldUtility.Services
{
    public class ConfigurationAppSettings : IAppSettings
    {
        public string GetName(string name)
        {
            return ConfigurationManager.AppSettings.Get(name);
        }
    }
}
