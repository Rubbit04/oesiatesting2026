using Xunit;
using MiApp2;
namespace MiApp2.test
{
public class NotaTests

    {
        [Fact]
        public void Nota_Aprobada_Test()
        {

            // arrange preparar
            var nota = new Nota(5.5);
            // act ejecuto el codigo
            string calificacion = nota.ObtenerCalificacion();
            // assert verifico el resultado
            Assert.Equal("Aprobado", calificacion);
        }

        //Hay que probar los límites
        [Fact]
        public void Nota_Sobresaliente9_Test()
        {

            // arrange preparar
            var nota = new Nota(9);
            // act ejecuto el codigo
            string calificacion = nota.ObtenerCalificacion();
            // assert verifico el resultado
            Assert.Equal("Sobresaliente", calificacion);
        }

        [Fact]
        public void Nota_Sobresaliente10_Test()
        {

            // arrange preparar
            var nota = new Nota(10);
            // act ejecuto el codigo
            string calificacion = nota.ObtenerCalificacion();
            // assert verifico el resultado
            Assert.Equal("Sobresaliente", calificacion);
        }

        [Fact]
        public void Nota_Mayor_Diez_Test()
            {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>  new Nota(10.1));

            Assert.Contains("El valor debe estar entre 0 y 10", ex.Message);

            }
    }
}