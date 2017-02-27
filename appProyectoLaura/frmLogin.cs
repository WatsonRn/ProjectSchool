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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            pbLogin.Image = global::appProyectoLaura.Properties.Resources.loginUser;
            pbLogin.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BackgroundImage = global::appProyectoLaura.Properties.Resources.back;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
