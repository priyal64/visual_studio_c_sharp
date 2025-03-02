using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager instance = null;
        private static readonly object lockObject = new object();

        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new ConfigurationManager();
                        }
                    }
                }
                return instance;
            }
        }

        public string GetSetting(string key)
        {
            // Simulate getting a setting from a config file or database
            return $"Setting for {key}";
        }
    }

}
