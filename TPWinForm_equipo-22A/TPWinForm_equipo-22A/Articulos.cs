using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_22A
{
    internal class Articulos
    {
        public int IdArticulo { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public Marcas MarcaArticulo { get; set; }
        public Categorias CategoriaArticulo { get; set; }
        public decimal Precio { get; set; }

        public Articulos() { }
        public Articulos(int IdArticulo, string Codigo, string Nombre,
                         string Descripcion, Marcas MarcaArticulo, Categorias CategoriaArticulo,
                         decimal Precio)
        {
            this.IdArticulo = IdArticulo;
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.MarcaArticulo = MarcaArticulo;
            this.CategoriaArticulo = CategoriaArticulo;
            this.Precio = Precio;
        }
    }
}
