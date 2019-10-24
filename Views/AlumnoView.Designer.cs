namespace Views
{
    partial class AlumnoView
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableAlumnos = new System.Windows.Forms.DataGridView();
            this.Registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAlumnos
            // 
            this.tableAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Registro,
            this.DNI,
            this.Nombre,
            this.Apellido1,
            this.Apellido2});
            this.tableAlumnos.Location = new System.Drawing.Point(12, 12);
            this.tableAlumnos.Name = "tableAlumnos";
            this.tableAlumnos.Size = new System.Drawing.Size(763, 218);
            this.tableAlumnos.TabIndex = 0;
            // 
            // Registro
            // 
            this.Registro.HeaderText = "Registro";
            this.Registro.Name = "Registro";
            this.Registro.ReadOnly = true;
            this.Registro.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Registro.Width = 75;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Nombre.Width = 175;
            // 
            // Apellido1
            // 
            this.Apellido1.HeaderText = "1º Apellido";
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.Width = 175;
            // 
            // Apellido2
            // 
            this.Apellido2.HeaderText = "2º Apellido";
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.Width = 175;
            // 
            // AlumnoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.tableAlumnos);
            this.Name = "AlumnoView";
            ((System.ComponentModel.ISupportInitialize)(this.tableAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
    }
}
