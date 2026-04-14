using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_equipo_22A
{
    internal class Categoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }

        public Categoria()
        {
        }
        
        public Categoria(int IdCategoria, string Descripcion)
        {
            this.IdCategoria = IdCategoria;
            this.Descripcion = Descripcion;
        }
    }
}
