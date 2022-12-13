
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

            List<PersonaNueva> lista= repo.BuscarTodas();

            foreach (var persona in lista)
            {
                Console.Write(persona.Dni);
                Console.Write(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
                

            }
            Console.WriteLine("*******************");


            List<PersonaNueva> lista2= repo.BuscarTodasOrdenadasPorNombre();

            foreach (var persona in lista2)
            {
                
                Console.Write(persona.Nombre);
                Console.WriteLine(persona.Apellidos);
                Console.Write(persona.Dni);

            }
        }
    }
}

