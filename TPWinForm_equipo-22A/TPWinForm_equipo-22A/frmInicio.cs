using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_22A
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            // Instancio el formulario de modificación
            frmModificar modify = new frmModificar();

            // Seteo la propiedad Toplevel en false para que pueda mostrarse dentro del panel.
            // TopLevel es una propiedad que permite mostrar el contenido (frmModificar en este caso) en otro contenedor
            // Al establecerlo en FALSE, determino lo anterior.
            modify.TopLevel = false;

            // Seteo la propiedad Dock en Fill para frmModificar se ajuste al tamaño del panel.
            // Se puede hacer manualmente también.
            // Esta es otra manera de acceder.
            modify.Dock = DockStyle.Fill;

            // Limpio el panel y agrego frmPrincipal.
            pnlUniversal.Controls.Clear();
            pnlUniversal.Controls.Add(modify);

            modify.Show();
        }
    }
}
