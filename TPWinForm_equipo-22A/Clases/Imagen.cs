using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Imagen
    {
        public int IdArticulo { set; get; }
        public int IdImagen { set; get; }
        public string UrlImagen { set; get; }

        public Imagen() { }
        public Imagen(int IdArticulo, int IdImagen, string UrlImagen) { 
        
            this.IdArticulo = IdArticulo;
            this.IdImagen = IdImagen;
            this.UrlImagen = UrlImagen;
        }
    }
}
