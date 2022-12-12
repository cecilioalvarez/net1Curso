using MySql.Data.MySqlClient;

namespace net1
{
    public class PersonaRepository {


        public MySqlConnection ObtenerConexion() {


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
            return conn;


        }

    }  
 }
