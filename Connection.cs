﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HosManage
{
    class Connection
    {
        private static string stringConnection = @"Data Source=VŨHƯƠNGQUỲNH\SQLEXPRESS;Initial Catalog=HospitalManagementSystem;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        


        public static void loaddata()
        {

        }
    }
}
