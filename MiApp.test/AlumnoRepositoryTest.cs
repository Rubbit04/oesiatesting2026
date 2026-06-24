using Xunit;
using MiApp;

namespace MiApp.test
{
    public class AlumnoRepositoryTest

    {
        [Fact]
        public void Alumno_BuscarTodos_Test()

        {
            var alumnos = new List<Alumno>
        {
        new() { Id = 1, Nombre = "Ana García"    },
        new() { Id = 2, Nombre = "Luis Martínez" },
        new() { Id = 3, Nombre = "Sara López"    }
        };

            AlumnoRepository repository = new AlumnoRepository(alumnos);
            List<Alumno> lista = repository.ObtenerTodos();
            Assert.Equal(3, lista.Count);
        }

        [Fact]
        public void Alumno_Buscar_Por_Id_Testt()
        {
            var alumnos = new List<Alumno>
        {
        new() { Id = 1, Nombre = "Ana García"    },
        new() { Id = 2, Nombre = "Luis Martínez" },
        new() { Id = 3, Nombre = "Sara López"    },
        new() { Id = 4, Nombre = "Pedro López"  }
        };

            AlumnoRepository repository = new AlumnoRepository(alumnos);
            Alumno? alumno = repository.BuscarPorId(2);

            Assert.Equal(2, alumno?.Id);
            Assert.Equal("Luis Martínez", alumno?.Nombre);
            
        }

        
    }

}