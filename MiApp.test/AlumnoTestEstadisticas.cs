using Xunit;
using MiApp;

namespace MiApp.test
{
    public class AlumnoTestsEstadisticas

    {
        private readonly Alumno alumnoConNotas;
        public AlumnoTestsEstadisticas()
        {
            alumnoConNotas = new Alumno(1, "Antonio", CrearListaNotas(8, 1.5, 9, 4, 7, 6));
        }

        [Fact]
        public void Alumno_MejorNota_Test()
        {

            //Act
            Nota? notaMejor = alumnoConNotas.ObtenerMejorNota();

            //Assert
            Assert.Equal(new Nota(9), notaMejor);

        }

        [Fact]
        public void Alumno_PeorNota_Test()
        {

            //Act
            Nota? notaPeor = alumnoConNotas.ObtenerPeorNota();

            //Assert
            Assert.Equal(new Nota(1.5), notaPeor);

        }
        //Incrementar el nnivel de aislamiento de los tests y que cada uno sea muy independiente
        [Fact]

    public void ObtenerNotaMedia_CuandoHayNotas_DevuelveLaMedia()

    {
        // Arrange
        var alumnoConNotas = new Alumno(1, "Juan", CrearListaNotas(10, 0, 10));
        // Act
        double resultado = alumnoConNotas.ObtenerNotaMedia();
        // Assert
        Assert.Equal(6.67, resultado, precision: 2);

    }




        private List<Nota> CrearListaNotas(params double[] valores)

        {

            return valores.Select(v => new Nota(v)).ToList();

        }
    }

}