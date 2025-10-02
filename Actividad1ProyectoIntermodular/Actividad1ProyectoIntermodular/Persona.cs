using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1ProyectoIntermodular
{
    class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string MostrarDatos()
        {
            return $"Nombre: {nombre} y Edad: {edad}";
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
