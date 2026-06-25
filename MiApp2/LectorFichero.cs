namespace MiApp2;

public class LectorFichero
{

    private string ruta;

    public LectorFichero(string ruta)
    {
        this.ruta = ruta;
    }

    public List<string> leerLineas()
    {
        return new List<string>(File.ReadAllLines(ruta));
    }
}
