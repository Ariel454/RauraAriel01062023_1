using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RauraAriel01062023_1
{
    internal class Persona
    {
        public String? Nombre   { get; set; }
        public int? Edad { get; set; }
        public String? Nacionalidad { get; set; }

        public Persona(string? nombre, int? edad, string? nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
        }   
    }
}
