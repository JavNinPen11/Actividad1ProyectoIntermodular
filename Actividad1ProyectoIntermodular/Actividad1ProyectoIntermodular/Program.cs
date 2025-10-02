// See https://aka.ms/new-console-template for more information
using Actividad1ProyectoIntermodular;

Console.WriteLine("Hello, World!");

Persona persona = new Persona("Juan", 25);

Console.WriteLine(persona.MostrarDatos());

persona.SetNombre("Carlos");

Console.WriteLine(persona.MostrarDatos());
