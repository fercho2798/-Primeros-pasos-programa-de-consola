using System;

namespace Creacion_De_Un_Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");
            Random generador = new Random();

            int id = generador.Next();
            string nombre = "Fernando";

            Computadora computadora = new Computadora 
            {
                Id = generador.Next(),
                Marca = "Azus",
                Modelo = "intel core i7",
                Precio = 800
            };
            Refrigeradora refrigeradora = new Refrigeradora
            {
                Id= generador.Next(),
                Marca = "Indurama",
                Modelo= "x233-44",
                Precio= 200
            };

            Persona estudiante = new Persona
            {
                Id = id,
                Nombre = nombre,
                MiComputadora = computadora,
                Mirefri = refrigeradora
                
            };



            string personaLaQueSaludo = "Pedro";

            string saludo = estudiante.Saludar(personaLaQueSaludo);
            string productos = estudiante.Productos();

            Console.WriteLine(saludo);
            Console.WriteLine(productos);

            Console.ReadKey();
        }
    }
}
