using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace TMS.Util
{
    public static class DBConnUtil
    {
        private static string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=TMS;Integrated Security=True;Trust Server Certificate=True";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
