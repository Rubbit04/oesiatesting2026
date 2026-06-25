using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MiApp2.Test")]

string[] lineas = File.ReadAllLines("datosalumnos.txt");
foreach (string linea in lineas)
{
    Console.WriteLine(linea);
}