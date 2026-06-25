using System;
using System.Collections.Generic;
using Xunit;
using MiApp;

namespace MiApp.test
{
    public class ContadorAprobadosTests
    {
        [Fact]
        public void AgregarNota_IncrementaAprobadosSoloCuandoLaNotaEsAprobada()
        {
            var contador = new ContadorAprobados();

            contador.AgregarNota(new Nota(4.9));
            contador.AgregarNota(new Nota(5.0));
            contador.AgregarNota(new Nota(7.5));

            Assert.Equal(2, contador.Aprobados);
        }

        [Fact]
        public void ContarAprobados_CuentaTodasLasNotasAprobadas()
        {
            var notas = new List<Nota>
            {
                new Nota(2.0),
                new Nota(5.0),
                new Nota(6.0),
                new Nota(4.0),
                new Nota(9.0)
            };

            var contador = new ContadorAprobados();
            int resultado = contador.ContarAprobados(notas);

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void AgregarNota_ThrowsArgumentNullException_WhenNotaIsNull()
        {
            var contador = new ContadorAprobados();

            Assert.Throws<ArgumentNullException>(() => contador.AgregarNota(null!));
        }

        [Fact]
        public void ContarAprobados_ThrowsArgumentNullException_WhenNotasIsNull()
        {
            var contador = new ContadorAprobados();

            Assert.Throws<ArgumentNullException>(() => contador.ContarAprobados(null!));
        }
    }
}
