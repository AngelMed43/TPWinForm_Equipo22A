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

        private void btnNuevoArticulo_Click(object sender, EventArgs e)
        {
            Form formOpen = new frmNuevoArticulo();

            formOpen.TopLevel = false;
            formOpen.Dock = DockStyle.Fill;

            pnlUniversal.Controls.Clear();
            pnlUniversal.Controls.Add(formOpen);
            formOpen.Show();
        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Form formAabrir;

            pbLogo.Visible = false;

            if (tcMenu.SelectedTab.Name == "Articulos")
            {
                formAabrir = new frmModificarArticulo();
            }
            else if (tcMenu.SelectedTab.Name == "Categorias")
            {
                formAabrir = new frmModificarCategoria();
            }
            else
            {
                return;
            }

            

            formAabrir.TopLevel = false;
            formAabrir.Dock = DockStyle.Fill;

            pnlUniversal.Controls.Clear();
            pnlUniversal.Controls.Add(formAabrir);

            formAabrir.Show();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMenu.SelectedTab.Name == "Articulos")
            {
                btnNuevoArticulo.Visible = true;
                btnModificarArticulo.Visible = true;
                btnEliminarArticulo.Visible = true;
                btnDetallesArticulo.Visible = true;
            }
            else if (tcMenu.SelectedTab.Name == "Categorias")
            {
                btnNuevoArticulo.Visible = false;
                btnModificarArticulo.Visible = true;
                btnEliminarArticulo.Visible = true;
                btnDetallesArticulo.Visible = false;
            }
        }

    }
}

