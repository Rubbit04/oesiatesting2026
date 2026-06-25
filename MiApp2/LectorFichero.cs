namespace MiApp2;

public class LectorFichero
{

    private string ruta;

    public LectorFichero(string ruta)
    {
        this.ruta = ruta;
    }

    public List<string> LeerLineas()
    {
        string[] lineas = File.ReadAllLines(ruta);
        List<string> nuevas = new List<string>();
        foreach (string linea in lineas)
        {
            nuevas.Add(linea);
        }
        return nuevas;
    }
}
