using Xunit;
using MiApp2;

namespace MiApp2.test
{
    public class AlumnoTests

    {
        [Fact]
        public void Alumno_No_Tiene_Notas()
        {
            // arrange preparar
            var alumno = new Alumno(1, "Pedro");

            Assert.Single(alumno.Notas);
        }

        [Fact]
        public void Alumno_AgregarNota_Test()
        {
            // arrange preparar 

            var alumno = new Alumno(1, "pedro", new List<Nota>());
            var nota = new Nota(7);

            //assert guard y sirve para validar antes de actuar que los datos iniciales son ok

            Assert.Empty(alumno.Notas);
            alumno.AgregarNota(nota);

            //assert validar
            Assert.Contains(nota, alumno.Notas);
            Assert.Single(alumno.Notas);

        }

        [Fact]
        public void Alumno_EliminarNota_Test()
        {
            // arrange preparar 
            Nota nota = new Nota(8);
            var alumno = new Alumno(1, "Pepe", new List<Nota>{nota});

            // act ejecuto el codigo
            alumno.EliminarNota(nota);

            //Assert
            Assert.DoesNotContain(nota, alumno.Notas);
        }

        [Fact]
        public void Alumno_MejorNota_Test()
        {
            //Arrange
            Alumno alumno = new Alumno (1, "Antonio", CrearListaNotas(8, 1.5, 9, 4, 7, 6));
        
            //Act
            Nota? notaMejor = alumno.ObtenerMejorNota();

            //Assert
            Assert.Equal(new Nota(9), notaMejor);
            
        }

         [Fact]
        public void Alumno_PeorNota_Test()
        {
            //Arrange
            Alumno alumno = new Alumno (1, "Antonio", CrearListaNotas(8, 1.5, 9, 4, 7, 6));
        
            //Act
            Nota? notaPeor = alumno.ObtenerPeorNota();

            //Assert
            Assert.Equal(new Nota(1.5), notaPeor);
            
        }
        private List<Nota> CrearListaNotas(params double[] valores)

    {

        return valores.Select(v => new Nota(v)).ToList();

    }
    }
    
}