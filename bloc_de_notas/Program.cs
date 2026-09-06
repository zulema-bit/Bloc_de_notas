using System;

string[] notas = new string[3];

Console.WriteLine("--- BLOC DE NOTAS DE LOS ESTUDIANTES ---");

for (int i = 0; i < 3; i++)
{
    Console.Write($"Ingresa la nota número {i + 1}: ");
    notas[i] = Console.ReadLine(); 
}

Console.WriteLine("\n--- SE GUARDARON LAS NOTAS ---");


for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"{i + 1}. {notas[i]}");
}

Console.WriteLine("\nPresiona cualquier tecla para salir...");
Console.ReadKey();
