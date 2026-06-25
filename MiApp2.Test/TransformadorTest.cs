using MiApp2;
using System.IO;
using System.Reflection;
using Xunit;
using Moq;

namespace MiApp2.test;

public class TransformadorTest
{
    [Fact]
    public void Validar_Dependencia_Transformador_Lector_Test()
    {
        Mock<LectorFichero> mockLectorFichero = new Mock<LectorFichero>();
        TransformadorClase transformadorClase = new TransformadorClase(mockLectorFichero.Object);
        Clase clase = transformadorClase.ObtenerClaseConoAlumnos();
        
        mockLectorFichero.Verify(l=> l.leerLineas(), Times.Once);
    }
}