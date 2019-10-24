

namespace Models
{
    public class Alumno
    {
        public int registro { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }

        public Alumno(int registro, string dni, string nombre, string apellido1, string apellido2)
        {
            this.registro = registro;
            this.dni = dni;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
        }

        public Alumno()
        {
        }


    }
}
