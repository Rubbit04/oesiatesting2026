using System;
using System.Collections.Generic;
using System.Linq;

namespace MiApp
{
    public class ContadorAprobados
    {
        private int aprobados;

        public int Aprobados => aprobados;

        public void AgregarNota(Nota nota)
        {
            if (nota is null)
                throw new ArgumentNullException(nameof(nota));

            if (nota.Valor >= 5)
            {
                aprobados++;
            }
        }

        public int ContarAprobados(IEnumerable<Nota> notas)
        {
            if (notas is null)
                throw new ArgumentNullException(nameof(notas));

            return notas.Count(n => n.Valor >= 5);
        }
    }
}
