using dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_22A
{
    public static class Validaciones
    {
        // Devuelve true si todo está bien; false si hay algún error (y muestra el MessageBox correspondiente).
        // Debe permitir si o si codigo(admite letra y numero) y nombre.
        // Descripcion opcional
        // Marca obligatoria
        // categoria obligatoria
        // Precio se puede vacio.
        // Urlimagen, validar si esta correcta.
        // Imagen admite vacio.
        public static bool ValidarArticulo(string codigo,string nombre,bool marcaSeleccionada,bool categoriaSeleccionada,string precio,string urlImagen)
        {
            
            
            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("El código es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            
            if (!marcaSeleccionada)
            {
                MessageBox.Show("Debe seleccionar una marca.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!categoriaSeleccionada)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Precio: opcional, pero si se ingresa debe ser maypr o igual 0 
            if (!string.IsNullOrWhiteSpace(precio))
            {
                if (!decimal.TryParse(precio, out decimal precioVal) || precioVal < 0)
                {
                    MessageBox.Show("El precio debe ser un número positivo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            
            if (!string.IsNullOrWhiteSpace(urlImagen))
            {
                // Verifica de forma sencilla si empieza con http:// o https://
                if (!urlImagen.Trim().ToLower().StartsWith("http"))
                {
                    MessageBox.Show("La URL debe ser válida (http:// o https://).", "Validación");
                    return false;
                }
            }

            return true;
        }

        public static decimal ParsearPrecio(string texto)
        {
            decimal.TryParse(texto, out decimal val);
            return val;
        }
        
        
    }
}

