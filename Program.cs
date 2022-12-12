
using System;
using net1;
using MySql.Data.MySqlClient;
namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {

             var sb = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "root",
                Port = 3306,
                Database = "curso2"
            };


         Console.WriteLine("hola");
        }
    }
}

