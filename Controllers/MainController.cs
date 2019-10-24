using System;
using System.Windows.Forms;
using Models;
using Views;
using System.Collections;

namespace Controllers
{
    static class MainController
    {
        private static Conexion conexion;
        private static AlumnoDao alumnoDao;
        private static AlumnoView alumnoView;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            conexion = new Conexion();
            alumnoDao = new AlumnoDao(conexion.conexion);
            alumnoView = new AlumnoView();
            alumnoDao.UpdateAlumno(new Alumno(3, "44F", "James", "Bond", "Del Campo"));
            chargeTable();
            Application.Run(alumnoView);
        }

        public static void chargeTable()
        {
            alumnoView.TableAlumno.Rows.Clear();
            ArrayList alumnosList = alumnoDao.GetAllAlumnos();
            for (int i = 0; i < alumnosList.Count; i++)
            {
                int n = alumnoView.TableAlumno.Rows.Add();
                alumnoView.TableAlumno.Rows[n].Cells[0].Value = ((Alumno)alumnosList[i]).registro;
                alumnoView.TableAlumno.Rows[n].Cells[1].Value = ((Alumno)alumnosList[i]).dni;
                alumnoView.TableAlumno.Rows[n].Cells[2].Value = ((Alumno)alumnosList[i]).nombre;
                alumnoView.TableAlumno.Rows[n].Cells[3].Value = ((Alumno)alumnosList[i]).apellido1;
                alumnoView.TableAlumno.Rows[n].Cells[4].Value = ((Alumno)alumnosList[i]).apellido2;
            }
        }
    }
}
