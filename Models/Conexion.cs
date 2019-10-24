using MySql.Data.MySqlClient;

namespace Models
{
    public class Conexion
    {

        public MySqlConnection conexion { get; set; }


        public Conexion()
        {
            this.conexion = new MySqlConnection("server=localhost;database=db_biblioteca;Uid=root;pwd=elrincon1920;");
            this.conexion.Open();
        }


    }
}
