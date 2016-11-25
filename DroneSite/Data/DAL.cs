using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DroneSite
{
    public class DAL
    {
        public SqlConnection openDB()
        {
            SqlConnection conn = new SqlConnection();
            // TODO Insert actual db name (found in web config) below
            string connString = ConfigurationManager.ConnectionStrings["void"].ConnectionString;
            conn.ConnectionString = connString;
            conn.Open();

            return conn;
        }

        public void closeDB(SqlConnection conn)
        {
            conn.Close();
        }


    }
}