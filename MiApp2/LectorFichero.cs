namespace MiApp2;

public class LectorFichero
{

    private string ruta;

    public LectorFichero()
    {
        
    }

    public LectorFichero(string ruta)
    {
        this.ruta = ruta;
    }

    public virtual List<string> leerLineas()
    {
        return new List<string>(File.ReadAllLines(ruta));
    }
}
