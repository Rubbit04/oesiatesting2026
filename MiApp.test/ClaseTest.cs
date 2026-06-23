using MiApp;
public class ClaseTests

{

    [Fact]

    public void AgregarAlumno_CuandoSeAgrega_ElAlumnoEstaEnLaLista()

    {
        // Arrange
        var claseVacia = new Clase("Matemáticas");
        var alumno = new Alumno(1, "Juan");

        // Act
        claseVacia.AgregarAlumno(alumno);

        // Assert

        Assert.Single(claseVacia.Alumnos);
        Assert.Contains(alumno, claseVacia.Alumnos);

    }

    [Fact]
    public void EliminarAlumno_CuandoSeElimina_ElAlumnoNoEstaEnLaLista()

    {
        // Arrange
        var alumno = new Alumno(1, "Juan");
        var claseConAlumno = new Clase("Matemáticas", new List<Alumno> { alumno });

        // Act
        claseConAlumno.EliminarAlumno(alumno);

        // Assert
        Assert.Empty(claseConAlumno.Alumnos);
    }

}