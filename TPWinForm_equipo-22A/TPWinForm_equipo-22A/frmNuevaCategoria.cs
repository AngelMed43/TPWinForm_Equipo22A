using Conexion_BDD;
using dominio;
using negocio;
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
    public partial class frmNuevaCategoria : Form
    {
        private frmInicio frmInicio;
        public frmNuevaCategoria(frmInicio formInicio)
        {
            InitializeComponent();
            frmInicio = formInicio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmNuevaCategoria_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                int proximoId = negocio.obtenerProximoId();
                IDGenerado.Text = proximoId.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Al Cargar ID" + ex.ToString());
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Categoria Categoria = new Categoria();
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                Categoria.Descripcion = txtBDescripcionNuevaCategoria.Text;

                negocio.agregar(Categoria);
                MessageBox.Show("Agregado exitosamente");

                frmInicio.cargarListadoCategorias();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

