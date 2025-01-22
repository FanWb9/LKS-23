using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS_23
{
    internal class Database
    {
        private static readonly string conn = "Data Source=DESKTOP-L1O0RI0\\IRFAN;Initial Catalog = EsemkaFoodCourt;Integrated security = true";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(conn);
        }
    }
}
