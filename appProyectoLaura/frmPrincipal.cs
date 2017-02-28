using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appProyectoLaura
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.tlsAgregar.Image = global::appProyectoLaura.Properties.Resources.add_1;
            this.tlsEliminar.Image = global::appProyectoLaura.Properties.Resources.minus_1;
            this.tlsModificar.Image = global::appProyectoLaura.Properties.Resources.edit;
            this.tlsGuardar.Image = global::appProyectoLaura.Properties.Resources.pdf_file_format_symbol;
            this.tlsImprimir.Image = global::appProyectoLaura.Properties.Resources.print;
            this.tlsCerrar.Image = global::appProyectoLaura.Properties.Resources.close;
            this.tlsHerramientas.BackgroundImage = global::appProyectoLaura.Properties.Resources.Back4;
            this.tlsHerramientas.BackgroundImageLayout = ImageLayout.Stretch;
            this.tlsHerramientas.RenderMode = ToolStripRenderMode.System;
            frmLista li = new frmLista();
            li.MdiParent = this;
            li.Show();
            //this.tlsAgregar.ForeColor = Color.GreenYellow;
            /*this.tlsAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            this.tlsAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tlsAgregar.Name = "toolStripButton1";
            this.tlsAgregar.Text = "&New";
            this.tlsAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tlsAgregar.Click += new System.EventHandler(this.tlsAgregar_Click);*/
        }

        private void tlsCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tlsAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar ag = new frmAgregar();
            ag.MdiParent = this;
            ag.Show();
        }

        private void tlsModificar_Click(object sender, EventArgs e)
        {
            frmModificar mod = new frmModificar();
            mod.MdiParent = this;
            mod.Show();
        }
    }
}
