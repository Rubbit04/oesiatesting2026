namespace MiApp2;

public abstract class ParseadorDocumento
{

    protected abstract List<string> ObtenerLineasFiltradas();

    protected abstract void ProcesarLinea(Clase miClase, string linea);


    public Clase ObtenerClaseConAlumnos()
    {
        Clase miClase = new Clase();
        List<string> lineas = ObtenerLineasFiltradas();

        foreach (string linea in lineas)
        {
            // if (!linea.Contains("-"))
            ProcesarLinea(miClase, linea);
        }

        return miClase;
    }

    
    
    public Alumno ObtenerOCrearAlumno(Clase miClase, string nombre)
    {
        Alumno alumno = new Alumno();
        alumno.Nombre = nombre;

        int posicion = miClase.Alumnos.IndexOf(alumno);
        if (posicion == -1)
        {
            miClase.AgregarAlumno(alumno);
            return alumno;
        }

        return miClase.Alumnos[posicion];
    }
}