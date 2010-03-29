using System;
using System.Configuration;

namespace MavenThought.MediaLibrary.Core
{
    public static class AppConfigHelpers
    {
        public static string STR_CannotFindConnectionFormatString = "Cannot find connection string: {0}";
        public static string STR_MachineSpecificFormatString = "{1}-{0}";

        public static string ToMachineSpecificConfigKey(this string abstractConfigKeyName)
        {
            return String.Format(STR_MachineSpecificFormatString, Environment.MachineName, abstractConfigKeyName);
        }

        public static string ToMachineSpecificConnectionString(this string abstractConnectionStringName)
        {
            var concreteConnectionStringName = abstractConnectionStringName.ToMachineSpecificConfigKey();

            if (ConfigurationManager.ConnectionStrings[concreteConnectionStringName] == null)
            {
                throw new InvalidOperationException(String.Format(STR_CannotFindConnectionFormatString, concreteConnectionStringName));
            }

            return ConfigurationManager.ConnectionStrings[concreteConnectionStringName].ConnectionString;
        }
    }
}
