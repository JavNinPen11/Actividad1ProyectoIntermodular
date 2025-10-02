using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1ProyectoIntermodular
{
    internal class Producto
    {
        
        private string nombre;
        private double precio;

        public Producto(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string MostrarDatos()
        {
            return $"Nombre: {nombre} y precio: {precio} $";
        }
    
}
}
