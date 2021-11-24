
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.ComponentModel;
using ExportGarPostgreSQLCore.Service;

namespace ExportGarPostgreSQLCore.Data
{
    public class ReturnDataBase
    {
        public  void  ReturnDT(string cmdText, string connStr)
        {
            //string connStr = "Server = localhost; Port = 5432; CommandTimeout = 9999990; Database = tymen; User ID = postgres; Password = 666; MaxPoolSize = 250;";
            //string connStr = "Server = 192.168.1.51; Port = 5432; CommandTimeout = 9999990; Database = chelyabinsk; User ID = postgres; Password = 1234; MaxPoolSize = 250;";
            //string connStr = "Server=172.16.10.198;Database=gkhfree;User ID = bars; Password = 123;";
            NpgsqlConnection conn = new NpgsqlConnection(connStr); // connStr это адресс сервера  Npgsql Connection устанавливает соединение с сервером  PostgreSQL.
            NpgsqlCommand cmd = new NpgsqlCommand(cmdText, conn); // NpgsqlCommand передаёт запрос в сервер по указанному адресу 
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd); // адаптер из многих команд: выбрать, обновить, вставить и удалить, чтобы заполнить.
            conn.Open(); // Открывает соединение с базой данных с настройками свойств, указанными в  conn
            CreateFiasXML createFiasXML = new CreateFiasXML();
            createFiasXML.CreateFiasHouseXML(adapter);
            // Представляет одну таблицу данных в памяти.
            Console.WriteLine("Данные сохранены в файл xml");
            conn.Close(); // Закрывает соединение с базой данных с настройками свойств, указанными в  conn

        }
    }
}
        