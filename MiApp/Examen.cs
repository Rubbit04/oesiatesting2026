public enum TipoExamen
{
    Normal,
    Extraordinario,
    Recuperacion
}

public enum Nivel

{
    Basico,
    Intermedio,
    Avanzado
}

public class Examen
{
    public int        Valor      { get; set; }
    public Nivel      Nivel      { get; set; }
    public TipoExamen TipoExamen { get; set; }
}