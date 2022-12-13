
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

            foreach (var persona in lista)
            {
                Console.Write(persona.Dni);
                Console.Write(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
                

            }
           

         Console.WriteLine("hola");
        }
    }
}

