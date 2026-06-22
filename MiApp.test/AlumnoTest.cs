using Xunit;
using MiApp;

namespace MiApp.test
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
            var alumno = new Alumno(1, "Pedro");
            var nota = new Nota(7);

            // act ejecuto el codigo
            alumno.AgregarNota(nota);

            // assert verifico el resultado
            var notas = alumno.Notas;
            Assert.Contains(nota, notas);
        }

        [Fact]
        public void Alumno_EliminarNota_Test()
        {
            // arrange preparar 
            var alumno = new Alumno(1, "Pepe");
   
            // act ejecuto el codigo
            alumno.EliminarNota(alumno.Notas[0]);

            //assert verifico el resultado
            Assert.Empty(alumno.Notas);
        }        


    }
}