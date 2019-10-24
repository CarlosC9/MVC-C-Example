using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Views
{
    public partial class AlumnoView: Form
    {
        public DataGridView TableAlumno
        {
            get
            {
                return this.tableAlumnos;
            }
        }

        public NumericUpDown RegistroText
        {
            get
            {
                return this.registroText;
            }
        }

        public TextBox DniText
        {
            get
            {
                return this.dniText;
            }
        }

        public TextBox NombreText
        {
            get
            {
                return this.nombreText;
            }
        }

        public TextBox Apellido1Text
        {
            get
            {
                return this.apellido1Text;
            }
        }

        public TextBox Apellido2Text
        {
            get
            {
                return this.apellido2Text;
            }
        }

        public Button ButtonAdd
        {
            get
            {
                return this.buttonAdd;
            }
        }

        public Button ButtonUpdate
        {
            get
            {
                return this.buttonUpdate;
            }
        }
        public Button ButtonDelete
        {
            get
            {
                return this.buttonDelete;
            }
        }


        public AlumnoView()
        {
            InitializeComponent();
        }

    }
}
