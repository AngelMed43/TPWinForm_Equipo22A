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
            Form formOpen;

            if (tcMenu.SelectedTab.Name == "Articulos")
            {
                formOpen = new frmNuevoArticulo();
            }
            //Descomentarlo cuando se agregue el frmNuevaCategoria
            //else if (tcMenu.SelectedTab.Name == "Categorias")
            //{
            //    formOpen = new frmNuevaCategoria();
            //}
            else if (tcMenu.SelectedTab.Name == "Marcas")
            {
                formOpen = new frmNuevaMarca();
            }
            else
            {
                return;
            }


            formOpen.TopLevel = false;
            formOpen.Dock = DockStyle.Fill;
            

            pnlUniversal.Controls.Clear();
            pnlUniversal.Controls.Add(formOpen);
            formOpen.Show();
        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Form formAabrir;

            

            if (tcMenu.SelectedTab.Name == "Articulos")
            {
                formAabrir = new frmModificarArticulo();
            }
            else if (tcMenu.SelectedTab.Name == "Categorias")
            {
                formAabrir = new frmModificarCategoria();
            }
            else if (tcMenu.SelectedTab.Name == "Marcas")
            {
                formAabrir = new frmModificarMarca();
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
                btnNuevoArticulo.Visible = true;
                btnModificarArticulo.Visible = true;
                btnEliminarArticulo.Visible = true;
                btnDetallesArticulo.Visible = false;
            }
            else if (tcMenu.SelectedTab.Name == "Marcas")
            {
                btnNuevoArticulo.Visible = true;
                btnModificarArticulo.Visible = true;
                btnEliminarArticulo.Visible = true;
                btnDetallesArticulo.Visible = false;
            }
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            // Confirmar que haya seleccionado algo primero.
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un artículo para eliminar.","Atención!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult confirmarEliminación = MessageBox.Show("¿ Esta seguro que desea eliminar el articulo seleccionado ?", "Mensaje de Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            //Logica para eliminar
        }
    }
}

