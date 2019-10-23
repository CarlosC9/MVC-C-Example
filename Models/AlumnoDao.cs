using MySql.Data.MySqlClient;
namespace Models
{

    class AlumnoDao
    {
        private MySqlConnection conexion;

        public AlumnoDao(MySqlConnection conexion)
        {
            this.conexion = conexion;
        }

       
    }


}
