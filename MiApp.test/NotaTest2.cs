using Xunit;
using MiApp;
namespace MiApp.test
{
    public class NotaTests2

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
        [Theory]
        [InlineData(9.5, "Sobresaliente")]
        [InlineData(9, "Sobresaliente")]
        [InlineData(10, "Sobresaliente")]
        public void Nota_Sobresaliente9_Test(double valor, string calificacion)
        {

            // arrange preparar
            var nota = new Nota(valor);
            // act ejecuto el codigo
            var micalificacion = nota.ObtenerCalificacion();
            // assert verifico el resultado
            Assert.Equal(calificacion, micalificacion);
        }

        [Theory]
        [InlineData(10.1)]
        [InlineData(-1)]
        public void Nota_Mayor_Diez_Test(double valor)
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => new Nota(valor));

            Assert.Contains("El valor debe estar entre 0 y 10", ex.Message);

        }
    }
}