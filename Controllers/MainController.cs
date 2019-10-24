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
            createEvents();
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

        public static void createEvents()
        {
            alumnoView.ButtonAdd.Click += new EventHandler(ButtonAddClick);
            alumnoView.ButtonUpdate.Click += new EventHandler(ButtonUpdateClick);
            alumnoView.ButtonDelete.Click += new EventHandler(ButtonDeleteClick);
        }

        public static Alumno getAlumnoWithTextBox()
        {
            int registro = (int)alumnoView.RegistroText.Value;
            string dni = alumnoView.DniText.Text;
            string nombre = alumnoView.NombreText.Text;
            string apellido1 = alumnoView.Apellido1Text.Text;
            string apellido2 = alumnoView.Apellido2Text.Text;

            return new Alumno(registro,dni,nombre,apellido1,apellido2);
        }

        private static void ButtonAddClick(object sender, System.EventArgs e)
        {
            alumnoDao.AddAlumno(getAlumnoWithTextBox());
            chargeTable();
        }

        private static void ButtonUpdateClick(object sender, System.EventArgs e)
        {
            alumnoDao.UpdateAlumno(getAlumnoWithTextBox());
            chargeTable();
        }
        private static void ButtonDeleteClick(object sender, System.EventArgs e)
        {
            alumnoDao.DeleteAlumno((int)alumnoView.RegistroText.Value);
            chargeTable();
        }
    }
}
