using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Marca
    {
        public int IdMarca { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        

        public Marca() { }
        public Marca(int IdMarca, string Nombre, string Descripcion)
        {
            this.IdMarca = IdMarca;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
        }
    }
}
