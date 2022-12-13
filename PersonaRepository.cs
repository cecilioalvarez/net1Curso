using MySql.Data.MySqlClient;
using System.Collections.Generic;
namespace net1
{
    public class PersonaRepository {


        public List<PersonaNueva> BuscarTodas() {


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

            List<PersonaNueva> lista=new List<PersonaNueva>();
            while(reader.Read()) {


                PersonaNueva p= new PersonaNueva(reader.GetString("dni"),
                reader.GetString("nombre"),
                reader.GetString("apellidos"));
                lista.Add(p);

            }

            return lista;


        }




        public List<PersonaNueva> BuscarTodasOrdenadasPorNombre() {


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
            comando.CommandText = "select * from  Personas order by nombre";
            var reader = 
            comando
            .ExecuteReader(System.Data.CommandBehavior.CloseConnection);

            List<PersonaNueva> lista=new List<PersonaNueva>();
            while(reader.Read()) {


                PersonaNueva p= new PersonaNueva(reader.GetString("dni"),
                reader.GetString("nombre"),
                reader.GetString("apellidos"));
                lista.Add(p);

            }

            return lista;


        }

public  void  Insertar(PersonaNueva persona) {


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
            comando.CommandText = 
            " insert into Personas values('" +persona.Dni+ "','"
             +persona.Nombre+"','" +persona.Apellidos+ "')"; 
            comando.ExecuteNonQuery();

          


        }


    }  
 }
