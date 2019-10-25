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
            data.Close();
            return alumnosList;
            
        }


        public void DeleteAlumno(int registro)
        {

            sql = new MySqlCommand("SELECT * FROM prestamos", this.conexion);
            MySqlDataReader data = sql.ExecuteReader();
            while (data.Read())
            {
                int registroNow = 0;
                if (Int32.TryParse(data.GetString(1),out registroNow))
                {
                    if (registro == registroNow)
                    {
                        data.Close();
                        CustomException.UserHaveLoanThrow(registro);
                    }
                }
                
            }
            data.Close();
            

            sql = new MySqlCommand("delete from alumnos where registro = " + registro, this.conexion);
            int numChanges = sql.ExecuteNonQuery();

            if (numChanges <= 0)
            {
                CustomException.RegisterNotExistThrow(registro);
            }

        }

        public void AddAlumno(Alumno alumno)
        {

            sql = new MySqlCommand(string.Format("Insert into alumnos values('{0}', '{1}', '{2}', '{3}', '{4}')",
                alumno.registro, alumno.dni, alumno.nombre, alumno.apellido1, alumno.apellido2), this.conexion);

            int numChanges = sql.ExecuteNonQuery();

            if (numChanges <= 0)
            {
                CustomException.RegisterExistThrow(alumno.registro);
            }
        }

        public void UpdateAlumno(Alumno alumno)
        {

            sql = new MySqlCommand(string.Format("Update alumnos set dni='{1}', nombre='{2}'," +
                " apellido1='{3}', apellido2='{4}' where registro = '{0}'", alumno.registro, alumno.dni, alumno.nombre, alumno.apellido1, alumno.apellido2),
                this.conexion);

            int numChanges = sql.ExecuteNonQuery();

            if (numChanges <= 0)
            {
                CustomException.RegisterNotExistThrow(alumno.registro);
            }

        }

    }


}
