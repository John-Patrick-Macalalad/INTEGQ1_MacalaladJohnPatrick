using System.Data.Common;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingApplication.DL
{
    class sqlData
    {
        static string connectionString = "Data Source=JAYPEE;Initial Catalog=OnlineShoppingApplication;Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}
