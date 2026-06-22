using Xunit;
using MiApp;
namespace MiApp.test
{
    public class NotaTests2

    {
        [Theory]
        [InlineData(4.9, "Suspenso")]
        [InlineData(5.5, "Aprobado")]
        [InlineData(6, "Aprobado")]
        public void Nota_Aprobada_Test(double valor, string calificacion)
        {

            // arrange preparar
            var nota = new Nota(valor);
            // act ejecuto el codigo
            var resultado = nota.ObtenerCalificacion();
            // assert verifico el resultado
            Assert.Equal(calificacion, resultado);
        }

        [Theory]
        [InlineData(6.5, "Bien")]
        [InlineData(7, "Bien")]
        public void Nota_Bien_Test(double valor, string calificacion)
        {

            // arrange preparar
            var nota = new Nota(valor);
            // act ejecuto el codigo
            var resultado = nota.ObtenerCalificacion();
            // assert verifico el resultado
            Assert.Equal(calificacion, resultado);
        }

        [Theory]
        [InlineData(7.5, "Notable")]
        [InlineData(8, "Notable")]
        [InlineData(8.5, "Notable")]
        public void Nota_Notable_Test(double valor, string calificacion)
        {

            // arrange preparar
            var nota = new Nota(valor);
            // act ejecuto el codigo
            var resultado = nota.ObtenerCalificacion();
            // assert verifico el resultado
            Assert.Equal(calificacion, resultado);
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

        [Fact]
        public void Nota_Igualdad_Test()
        {
            var nota1 = new Nota(5);
            var nota2 = new Nota(5);

            Assert.Equal(nota1, nota2);
        }

        [Fact]
        public void Nota_HashCode_Test()
        {
            var nota1 = new Nota(5);
            var nota2 = new Nota(5);
            int numero1=nota1.GetHashCode();
            int numero2=nota2.GetHashCode(); 

            Assert.Equal(nota1, nota2);
        }
                [Fact]
        public void Nota_No_Igualdad_Test()
        {
            // arrange preparar
            var alumno = new Alumno(1, "Pedro");
            var nota1 = new Nota(8);
            var nota2 = new Nota(9);

            // act ejecuto el codigo
            alumno.AgregarNota(nota1);
            alumno.AgregarNota(nota2);

            // assert verifico el resultado
            Assert.Contains(nota1, alumno.Notas);
            Assert.Contains(nota2, alumno.Notas);
        }

        [Fact]
        public void Nota_Equals_Test()
        {
            // arrange preparar
            var nota1 = new Nota(8);
            var nota2 = new Nota(8);
            int numero1 = nota1.GetHashCode();
            int numero2 = nota2.GetHashCode();

            // assert verifico el resultado
            Assert.Equal(nota1, nota2);
        }
    }
}