namespace appProyectoLaura
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.tlsHerramientas = new System.Windows.Forms.ToolStrip();
            this.tlsAgregar = new System.Windows.Forms.ToolStripButton();
            this.tlsEliminar = new System.Windows.Forms.ToolStripButton();
            this.tlsModificar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsImprimir = new System.Windows.Forms.ToolStripButton();
            this.tlsGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsCerrar = new System.Windows.Forms.ToolStripButton();
            this.stStatus = new System.Windows.Forms.StatusStrip();
            this.tlsHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsHerramientas
            // 
            this.tlsHerramientas.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlsHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsAgregar,
            this.tlsEliminar,
            this.tlsModificar,
            this.toolStripSeparator1,
            this.tlsImprimir,
            this.tlsGuardar,
            this.toolStripSeparator2,
            this.tlsCerrar});
            this.tlsHerramientas.Location = new System.Drawing.Point(0, 0);
            this.tlsHerramientas.Name = "tlsHerramientas";
            this.tlsHerramientas.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tlsHerramientas.Size = new System.Drawing.Size(764, 37);
            this.tlsHerramientas.TabIndex = 1;
            this.tlsHerramientas.Text = "Herramientas";
            // 
            // tlsAgregar
            // 
            this.tlsAgregar.Image = ((System.Drawing.Image)(resources.GetObject("tlsAgregar.Image")));
            this.tlsAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsAgregar.Name = "tlsAgregar";
            this.tlsAgregar.Size = new System.Drawing.Size(107, 34);
            this.tlsAgregar.Text = "Agregar";
            this.tlsAgregar.Click += new System.EventHandler(this.tlsAgregar_Click);
            // 
            // tlsEliminar
            // 
            this.tlsEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tlsEliminar.Image")));
            this.tlsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsEliminar.Name = "tlsEliminar";
            this.tlsEliminar.Size = new System.Drawing.Size(107, 34);
            this.tlsEliminar.Text = "Eliminar";
            // 
            // tlsModificar
            // 
            this.tlsModificar.Image = ((System.Drawing.Image)(resources.GetObject("tlsModificar.Image")));
            this.tlsModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsModificar.Name = "tlsModificar";
            this.tlsModificar.Size = new System.Drawing.Size(121, 34);
            this.tlsModificar.Text = "Modificar";
            this.tlsModificar.Click += new System.EventHandler(this.tlsModificar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // tlsImprimir
            // 
            this.tlsImprimir.Image = ((System.Drawing.Image)(resources.GetObject("tlsImprimir.Image")));
            this.tlsImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsImprimir.Name = "tlsImprimir";
            this.tlsImprimir.Size = new System.Drawing.Size(111, 34);
            this.tlsImprimir.Text = "Imprimir";
            // 
            // tlsGuardar
            // 
            this.tlsGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tlsGuardar.Image")));
            this.tlsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsGuardar.Name = "tlsGuardar";
            this.tlsGuardar.Size = new System.Drawing.Size(183, 34);
            this.tlsGuardar.Text = "Guardar Como...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // tlsCerrar
            // 
            this.tlsCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tlsCerrar.Image")));
            this.tlsCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsCerrar.Name = "tlsCerrar";
            this.tlsCerrar.Size = new System.Drawing.Size(89, 34);
            this.tlsCerrar.Text = "Cerrar";
            this.tlsCerrar.Click += new System.EventHandler(this.tlsCerrar_Click);
            // 
            // stStatus
            // 
            this.stStatus.Location = new System.Drawing.Point(0, 266);
            this.stStatus.Name = "stStatus";
            this.stStatus.Size = new System.Drawing.Size(764, 22);
            this.stStatus.TabIndex = 2;
            this.stStatus.Text = "Status";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 288);
            this.Controls.Add(this.stStatus);
            this.Controls.Add(this.tlsHerramientas);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.TopMost = true;
            this.tlsHerramientas.ResumeLayout(false);
            this.tlsHerramientas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsHerramientas;
        private System.Windows.Forms.ToolStripButton tlsAgregar;
        private System.Windows.Forms.StatusStrip stStatus;
        private System.Windows.Forms.ToolStripButton tlsEliminar;
        private System.Windows.Forms.ToolStripButton tlsModificar;
        private System.Windows.Forms.ToolStripButton tlsImprimir;
        private System.Windows.Forms.ToolStripButton tlsGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlsCerrar;

    }
}