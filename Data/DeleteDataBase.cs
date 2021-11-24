
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.ComponentModel;
namespace ExportGarPostgreSQLCore.Data
{
    public class DeleteDataBase
    {
        public void DeleteDB(string cmdText, string connStr)
        {
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
