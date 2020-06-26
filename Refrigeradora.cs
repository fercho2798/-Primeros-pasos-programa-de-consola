using System;
using System.Collections.Generic;
using System.Text;

namespace Creacion_De_Un_Programa
{
    class Refrigeradora
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public float Precio { get; set; }
        public float ConsumoElectrico { get; set; }
        public Persona Propietario { get; set; }
    }
}
