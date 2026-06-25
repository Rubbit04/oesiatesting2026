namespace MiApp2;

public class TransformadorClase
{
    private LectorFichero lector;
    public TransformadorClase(LectorFichero _lector)
    {
        lector=_lector;
    }

    public Clase ObtenerClaseConoAlumnos()
    {
        lector.leerLineas();
        return null;
    }
}
