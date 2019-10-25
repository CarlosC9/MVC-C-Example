using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
            alumnoView = new AlumnoView();
            try
            {
                conexion = new Conexion();
                alumnoDao = new AlumnoDao(conexion.conexion);
                createEvents();
                chargeTable();
                Application.Run(alumnoView);
            }
            catch (MySqlException)
            {
                MessageBox.Show(null,"Error fatal: Imposible conectar a la base de datos", "Error Fatal", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
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
            Alumno alumno = getAlumnoWithTextBox();
            try
            {
                alumnoDao.AddAlumno(alumno);
                chargeTable();
            }
            catch (CustomException ex)
            {
                switch (ex.type)
                {
                    case CustomException.REGISTER_EXISTS:
                        MessageBox.Show(alumnoView, ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chargeTable();
                        break;
                }
            }
            catch (MySqlException ex)
            {
                string duplicateError = string.Format("Duplicate entry '{0}' for key 'PRIMARY'",alumno.registro.ToString());
                if (ex.Message == duplicateError)
                {
                    MessageBox.Show(alumnoView, "Error : El registro " + alumno.registro + " ya existe",
                            "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    MessageBox.Show(alumnoView, "Error Fatal: No se puede ejecutar la sentencia", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }

        private static void ButtonUpdateClick(object sender, System.EventArgs e)
        {
            Alumno alumno = getAlumnoWithTextBox();
            try
            {
                alumnoDao.UpdateAlumno(alumno);
                chargeTable();
            }
            catch (CustomException ex)
            {
                switch (ex.type)
                {
                    case CustomException.REGISTER_NOTEXISTS:
                        MessageBox.Show(alumnoView, ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chargeTable();
                        break;
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show(alumnoView, "Error Fatal: No se puede ejecutar la sentencia", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        private static void ButtonDeleteClick(object sender, System.EventArgs e)
        {
            int registro = (int)alumnoView.RegistroText.Value;
            try
            {
                alumnoDao.DeleteAlumno(registro);
                chargeTable();
            }
            catch (CustomException ex)
            {
                switch (ex.type)
                {
                    case CustomException.REGISTER_NOTEXISTS:
                        MessageBox.Show(alumnoView, ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chargeTable();
                        break;
                    case CustomException.USER_HAVE_LOAN:
                        MessageBox.Show(alumnoView, ex.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        chargeTable();
                        break;
                }
            }
            catch (MySqlException)
            {
                MessageBox.Show(alumnoView, "Error Fatal: No se puede ejecutar la sentencia", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            
        }
    }
}
