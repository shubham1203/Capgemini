using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AdmissionSystem.DAL
{
    class AdmissionConfiguration
    {
        private static string providerName;

        public static string ProviderName
        {
            get { return AdmissionConfiguration.providerName; }
            set { AdmissionConfiguration.providerName = value; }
        }
        private static string connectionString;

        public static string ConnectionString
        {
            get { return AdmissionConfiguration.connectionString; }
            set { AdmissionConfiguration.connectionString = value; }
        }

        static AdmissionConfiguration()
        {
            providerName = ConfigurationManager.ConnectionStrings["AdmissionConnection"].ProviderName;
            connectionString = ConfigurationManager.ConnectionStrings["AdmissionConnection"].ConnectionString;
        }
    }
}
