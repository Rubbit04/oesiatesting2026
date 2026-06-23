using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("MiApp.Test")]

Calculadora c = new Calculadora();

Console.WriteLine(c.Suma(2,2));
