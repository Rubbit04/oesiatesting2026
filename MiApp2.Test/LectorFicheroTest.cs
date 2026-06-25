using MiApp2;
using System.Reflection;
using Xunit;

namespace MiApp2.test;

public class LectorFicheroTest
{
    [Fact]
    public void leerLineasTests()
    {
        LectorFichero lectorFichero = new LectorFichero("datosalumnos.txt");
        List<String> lineas = lectorFichero.LeerLineas();

    }
}