using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowCommon
{
    public class WindowConfig
    {
        public static string GetConfigFromKey(string key) {
            return ConfigurationManager.ConnectionStrings[key].ConnectionString;
        }
    }
}
