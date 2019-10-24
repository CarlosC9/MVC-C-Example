using MySql.Data.MySqlClient;
using System;
using System.Collections;

namespace Models
{

    public class AlumnoDao
    {
        private MySqlConnection conexion;
        MySqlCommand sql;

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


        public void DeleteAlumno(int registro)
        {

            sql = new MySqlCommand("delete from alumnos where registro = " + registro, this.conexion);
            int data = sql.ExecuteNonQuery();

        }

        public void AddAlumno(Alumno alumno)
        {

            sql = new MySqlCommand(string.Format("Insert into alumnos values('{0}', '{1}', '{2}', '{3}', '{4}')",
                alumno.registro, alumno.dni, alumno.nombre, alumno.apellido1, alumno.apellido2), this.conexion);

            int data = sql.ExecuteNonQuery();

        }

        public void UpdateAlumno(Alumno alumno)
        {

            sql = new MySqlCommand(string.Format("Update alumnos set dni='{1}', nombre='{2}'," +
                " apellido1='{3}', apellido2='{4}' where registro = '{0}'", alumno.registro, alumno.dni, alumno.nombre, alumno.apellido1, alumno.apellido2),
                this.conexion);

            int data = sql.ExecuteNonQuery();

        }

    }


}
