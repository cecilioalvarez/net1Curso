
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
            MySqlConnection conn = 
            new MySqlConnection(sb.ConnectionString);
            conn.Open();

            var comando = conn.CreateCommand();
            comando.CommandText = "select * from  Personas";
            var reader = 
            comando
            .ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            while(reader.Read()) {


                Console.WriteLine(reader.GetString("nombre"));
            }

         Console.WriteLine("hola");
        }
    }
}

