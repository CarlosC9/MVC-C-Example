using MySql.Data.MySqlClient;

namespace Models
{
    public class Conexion
    {

        private MySqlConnection conexion;

        public MySqlConnection MyConexion {
            get
            {
                return this.conexion;
            }
        }

        public Conexion()
        {
            this.conexion = new MySqlConnection("server=localhost;database=db_biblioteca;Uid=root;pwd=elrincon1920;");
            this.conexion.Open();
        }

    }
}
