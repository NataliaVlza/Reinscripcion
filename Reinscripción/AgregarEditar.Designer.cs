namespace Reinscripción
{
    partial class AgregarEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIDMateria = new System.Windows.Forms.Label();
            this.lblNombreMateria = new System.Windows.Forms.Label();
            this.lblTipoMateria = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNombreMateria = new System.Windows.Forms.TextBox();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nupCalificacion = new System.Windows.Forms.NumericUpDown();
            this.cbTipoMateria = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDMateria
            // 
            this.lblIDMateria.AutoSize = true;
            this.lblIDMateria.Location = new System.Drawing.Point(34, 40);
            this.lblIDMateria.Name = "lblIDMateria";
            this.lblIDMateria.Size = new System.Drawing.Size(59, 13);
            this.lblIDMateria.TabIndex = 0;
            this.lblIDMateria.Text = "ID Materia:";
            // 
            // lblNombreMateria
            // 
            this.lblNombreMateria.AutoSize = true;
            this.lblNombreMateria.Location = new System.Drawing.Point(34, 66);
            this.lblNombreMateria.Name = "lblNombreMateria";
            this.lblNombreMateria.Size = new System.Drawing.Size(85, 13);
            this.lblNombreMateria.TabIndex = 1;
            this.lblNombreMateria.Text = "Nombre Materia:";
            // 
            // lblTipoMateria
            // 
            this.lblTipoMateria.AutoSize = true;
            this.lblTipoMateria.Location = new System.Drawing.Point(34, 92);
            this.lblTipoMateria.Name = "lblTipoMateria";
            this.lblTipoMateria.Size = new System.Drawing.Size(69, 13);
            this.lblTipoMateria.TabIndex = 2;
            this.lblTipoMateria.Text = "Tipo Materia:";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(34, 115);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(44, 13);
            this.lblHorario.TabIndex = 3;
            this.lblHorario.Text = "Horario:";
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(34, 140);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(64, 13);
            this.lblCalificacion.TabIndex = 4;
            this.lblCalificacion.Text = "Calificación:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(154, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNombreMateria
            // 
            this.txtNombreMateria.Location = new System.Drawing.Point(154, 59);
            this.txtNombreMateria.Name = "txtNombreMateria";
            this.txtNombreMateria.Size = new System.Drawing.Size(100, 20);
            this.txtNombreMateria.TabIndex = 6;
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(154, 115);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(100, 20);
            this.txtHorario.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(28, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(124, 225);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nupCalificacion
            // 
            this.nupCalificacion.Location = new System.Drawing.Point(154, 141);
            this.nupCalificacion.Name = "nupCalificacion";
            this.nupCalificacion.Size = new System.Drawing.Size(100, 20);
            this.nupCalificacion.TabIndex = 12;
            // 
            // cbTipoMateria
            // 
            this.cbTipoMateria.Items.AddRange(new object[] {
            "Obligatoria",
            "Optativa",
            "Eje Formación Común"});
            this.cbTipoMateria.Location = new System.Drawing.Point(154, 85);
            this.cbTipoMateria.Name = "cbTipoMateria";
            this.cbTipoMateria.Size = new System.Drawing.Size(100, 21);
            this.cbTipoMateria.TabIndex = 0;
            // 
            // AgregarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 253);
            this.Controls.Add(this.cbTipoMateria);
            this.Controls.Add(this.nupCalificacion);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtHorario);
            this.Controls.Add(this.txtNombreMateria);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.lblTipoMateria);
            this.Controls.Add(this.lblNombreMateria);
            this.Controls.Add(this.lblIDMateria);
            this.Name = "AgregarEditar";
            this.Text = "AgregarEditar";
            ((System.ComponentModel.ISupportInitialize)(this.nupCalificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDMateria;
        private System.Windows.Forms.Label lblNombreMateria;
        private System.Windows.Forms.Label lblTipoMateria;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtNombreMateria;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nupCalificacion;
        private System.Windows.Forms.ComboBox cbTipoMateria;
    }
}