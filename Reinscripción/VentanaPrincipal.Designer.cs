namespace Reinscripción
{
    partial class VentanaPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.dgvReinscripcion = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbObtener = new System.Windows.Forms.ToolStripButton();
            this.tsbAgregarNuevaVentana = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarNuevaVentana = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReinscripcion)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvReinscripcion
            // 
            this.dgvReinscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReinscripcion.Location = new System.Drawing.Point(12, 53);
            this.dgvReinscripcion.Name = "dgvReinscripcion";
            this.dgvReinscripcion.ReadOnly = true;
            this.dgvReinscripcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReinscripcion.Size = new System.Drawing.Size(505, 219);
            this.dgvReinscripcion.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbObtener,
            this.tsbAgregarNuevaVentana,
            this.tsbEditarNuevaVentana,
            this.tsbEliminar,
            this.tsbSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(564, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbObtener
            // 
            this.tsbObtener.Image = ((System.Drawing.Image)(resources.GetObject("tsbObtener.Image")));
            this.tsbObtener.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbObtener.Name = "tsbObtener";
            this.tsbObtener.Size = new System.Drawing.Size(70, 22);
            this.tsbObtener.Text = "Obtener";
            this.tsbObtener.Click += new System.EventHandler(this.tsbObtener_Click);
            // 
            // tsbAgregarNuevaVentana
            // 
            this.tsbAgregarNuevaVentana.Image = ((System.Drawing.Image)(resources.GetObject("tsbAgregarNuevaVentana.Image")));
            this.tsbAgregarNuevaVentana.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAgregarNuevaVentana.Name = "tsbAgregarNuevaVentana";
            this.tsbAgregarNuevaVentana.Size = new System.Drawing.Size(145, 22);
            this.tsbAgregarNuevaVentana.Text = "AgregarNuevaVentana";
            this.tsbAgregarNuevaVentana.Click += new System.EventHandler(this.tsbAgregarNuevaVentana_Click);
            // 
            // tsbEditarNuevaVentana
            // 
            this.tsbEditarNuevaVentana.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditarNuevaVentana.Image")));
            this.tsbEditarNuevaVentana.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarNuevaVentana.Name = "tsbEditarNuevaVentana";
            this.tsbEditarNuevaVentana.Size = new System.Drawing.Size(133, 22);
            this.tsbEditarNuevaVentana.Text = "EditarNuevaVentana";
            this.tsbEditarNuevaVentana.Click += new System.EventHandler(this.tsbEditarNuevaVentana_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // tsbSalir
            // 
            this.tsbSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbSalir.Image")));
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(49, 22);
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvReinscripcion);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReinscripcion)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReinscripcion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbObtener;
        private System.Windows.Forms.ToolStripButton tsbAgregarNuevaVentana;
        private System.Windows.Forms.ToolStripButton tsbEditarNuevaVentana;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
    }
}

