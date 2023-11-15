using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipov1
{
    internal class dbs
    {
        private String connectionString;

        public String getConnectionString()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Prototipov1.Properties.Settings.crudConnectionString"].ConnectionString;
            return connectionString;
        }
    }
}
