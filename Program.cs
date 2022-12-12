
using System;
using net1;
using MySql.Data.MySqlClient;
namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaRepository repo= new PersonaRepository();

            MySqlConnection conn= repo.ObtenerConexion();


           

         Console.WriteLine("hola");
        }
    }
}

