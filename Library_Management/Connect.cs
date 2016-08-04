using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Library_Management
{
    class Connect
    {
        public static SqlConnection Connection()
        {
            String ConnectionString = @"Data Source=IJAZ-MYPC\SQLEXPRESS;Initial Catalog=Library_Management;Integrated Security=True";
            SqlConnection Con = new SqlConnection(ConnectionString);
            Con.Open();
            return Con;
        }
    }
}
