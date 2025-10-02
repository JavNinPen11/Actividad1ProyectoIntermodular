
﻿using Actividad1ProyectoIntermodular;

Persona persona1 = new Persona("Paula", 20);

Console.WriteLine(persona1.MostrarDatos());

Console.WriteLine(persona1.EsMayorDeEdad());

Console.ReadLine();

Persona persona = new Persona("Juan", 25);

Console.WriteLine(persona.MostrarDatos());

persona.SetNombre("Carlos");

Console.WriteLine(persona.MostrarDatos());

