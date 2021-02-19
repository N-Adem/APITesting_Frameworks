using System;
using System.Configuration;

namespace APIProjectOne
{
    public class AppConfigReader
    {
        public static readonly string baseUrl = ConfigurationManager.AppSettings["baseUrl"];
        public static readonly string apiKey = ConfigurationManager.AppSettings["apiKey"];
    }
}
