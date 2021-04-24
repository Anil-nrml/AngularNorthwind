using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ConfigurationManager
{
    public interface IConfigurastionManager
    {
        string GetCongfigValueFromAppSettings(string ConfigKey);
        string GetConfigurationFromDB(string Module, string ConfigKey);

    }
}
