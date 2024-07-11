using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApp
{
     class sqlClass
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;

    }
}
