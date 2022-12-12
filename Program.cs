
using System;
using net1;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace net1
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaRepository repo= new PersonaRepository();

            List<PersonaNueva> lista= repo.ObtenerConexion();


           

         Console.WriteLine("hola");
        }
    }
}

