using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brou_Davidspace
{
    public class Divers
    {
        // Connection string for MySQL DB
        public static string MySQLDBConX()
        {
            return @"User Id=root;Host=localhost;Database=dbwincan2023_brou_k_g7;Persist Security Info=True";
        }
    }
}
