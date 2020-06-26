

namespace Creacion_De_Un_Programa
{
    class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        Computadora LaComputadora;
        public Computadora MiComputadora
        {
            get
            {
                return LaComputadora;
            }

            set
            {
                LaComputadora = value;
                LaComputadora.Propietario = this;
            }
        }

        Refrigeradora Larefri;
        public Refrigeradora MiRefri
        {
            get
            {
                return Larefri;
            }

            set
            {
                Larefri = value;
                Larefri.Propietario = this;
            }
        }

        // Métodos - Comportamiento
        public string Saludar(string nombre)
        {
            return $"Hola {nombre} me llamo {Nombre}";
        }

        public string Productos()
        {
            if (LaComputadora != null && Larefri !=null)
                return $"tenguna una refri {Larefri.Modelo} y Tengo computadora {LaComputadora.Modelo}";
            else
                return "No tengo nada";
        }

    }
}
