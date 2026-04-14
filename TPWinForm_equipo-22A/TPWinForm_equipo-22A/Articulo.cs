using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_22A
{
    internal class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }

        public List<Imagen> Imagenes { get; set; }


        public Articulo() {
            Imagenes = new List<Imagen>();
        }
        public Articulo(int IdArticulo, string Codigo, string Nombre,
                         string Descripcion, Marca MarcaArticulo, Categoria CategoriaArticulo,
                         decimal Precio)
        {
            this.Id = IdArticulo;
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Marca = MarcaArticulo;
            this.Categoria = CategoriaArticulo;
            this.Precio = Precio;
            Imagenes = new List<Imagen>();
        }
    }
}
