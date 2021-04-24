using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ConfigurationManager
{
    public class ConfigurationManager : IConfigurastionManager
    {
        private Dictionary<string, Dictionary<string, string>> ConfigColloection;
        private void LoadConfigFromDB()
        {
             
           
        }
        public string GetConfigurationFromDB(string Module,string ConfigKey)
        {
            return ConfigColloection[Module][ConfigKey].ToString();
        }

        public string GetCongfigValueFromAppSettings(string ConfigKey)
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(ConfigKey);
        }

        
    }
}
