using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace Models
{

    public class AlumnoDao
    {
        private MySqlConnection conexion;

        public AlumnoDao(MySqlConnection conexion)
        {
            this.conexion = conexion;
        }

        public ArrayList GetAllAlumnos()
        {
            ArrayList alumnosList = new ArrayList();
            MySqlCommand command = new MySqlCommand("SELECT * FROM alumnos",this.conexion);
            MySqlDataReader data = command.ExecuteReader();
            while (data.Read())
            {
                Alumno alumno = new Alumno(data.GetInt32(0),data.GetString(1), data.GetString(2), data.GetString(3), data.GetString(4));
                alumnosList.Add(alumno);
            }
            return alumnosList;
        }
       
    }


}
