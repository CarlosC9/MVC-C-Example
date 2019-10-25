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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dniText = new System.Windows.Forms.TextBox();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.apellido1Text = new System.Windows.Forms.TextBox();
            this.apellido2Text = new System.Windows.Forms.TextBox();
            this.registroText = new System.Windows.Forms.NumericUpDown();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroText)).BeginInit();
            this.SuspendLayout();
            // 
            // tableAlumnos
            // 
            this.tableAlumnos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "1º Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "2º Apellido";
            // 
            // dniText
            // 
            this.dniText.Location = new System.Drawing.Point(26, 330);
            this.dniText.Name = "dniText";
            this.dniText.Size = new System.Drawing.Size(346, 20);
            this.dniText.TabIndex = 7;
            // 
            // nombreText
            // 
            this.nombreText.Location = new System.Drawing.Point(26, 381);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(346, 20);
            this.nombreText.TabIndex = 8;
            // 
            // apellido1Text
            // 
            this.apellido1Text.Location = new System.Drawing.Point(466, 272);
            this.apellido1Text.Name = "apellido1Text";
            this.apellido1Text.Size = new System.Drawing.Size(309, 20);
            this.apellido1Text.TabIndex = 9;
            // 
            // apellido2Text
            // 
            this.apellido2Text.Location = new System.Drawing.Point(466, 329);
            this.apellido2Text.Name = "apellido2Text";
            this.apellido2Text.Size = new System.Drawing.Size(309, 20);
            this.apellido2Text.TabIndex = 10;
            // 
            // registroText
            // 
            this.registroText.Location = new System.Drawing.Point(26, 272);
            this.registroText.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.registroText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.registroText.Name = "registroText";
            this.registroText.Size = new System.Drawing.Size(346, 20);
            this.registroText.TabIndex = 11;
            this.registroText.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(466, 377);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Añadir";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(564, 377);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 13;
            this.buttonUpdate.Text = "Actulizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(659, 377);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // AlumnoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.registroText);
            this.Controls.Add(this.apellido2Text);
            this.Controls.Add(this.apellido1Text);
            this.Controls.Add(this.nombreText);
            this.Controls.Add(this.dniText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableAlumnos);
            this.Name = "AlumnoView";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.tableAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dniText;
        private System.Windows.Forms.TextBox nombreText;
        private System.Windows.Forms.TextBox apellido1Text;
        private System.Windows.Forms.TextBox apellido2Text;
        private System.Windows.Forms.NumericUpDown registroText;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}
