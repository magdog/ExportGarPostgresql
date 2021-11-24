
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.ComponentModel;

namespace ExportGarPostgreSQLCore.Data
{
    public class UpdateDataBase
    {
        public  void UpdateTemp1DB(string cmdText, string connStr)
        {
            //string connStr = "Server = 192.168.1.51; Port = 5432; CommandTimeout = 9999990; Database = chelyabinsk; User ID = postgres; Password = 1234; MaxPoolSize = 250;";
            //string connStr = "Server = localhost; Port = 5432; CommandTimeout = 9999990; Database = tymen; User ID = postgres; Password = 666; MaxPoolSize = 250;";
            //string connStr = "Server=172.16.10.198;Database=gkhfree;User ID = bars; Password = 123;";
            NpgsqlConnection conn = new NpgsqlConnection(connStr);
            NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn);
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine(" успешно");

            }
            catch (Exception e)
            {
                Console.WriteLine(" не успешно " + e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
