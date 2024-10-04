public abstract class AccesoDatos
{
    protected AccesoDatos()
    {

    }
    public abstract Cadetria cargarCadeteria()
    {

    }

    public abstract void cargarCadete(Cadeteria cadetria)
    {

    }
}

public abstract class AccesoDatosCSV : AccesoDatos
{
    public AccesoDatosCSV() : base()
    {

    }
    public override Cadeteria cargarCadeteria()
    {
    string filePath = "Cadeteria.csv";
    Cadeteria cadeteria = new Cadeteria();

    try
    {
        string[] lineas = System.IO.File.ReadAllLines(filePath);

        foreach (string linea in lineas)
        {
            string[] campo = linea.Split(',');

            string columna1 = campo[0];
            int columna2 = int.Parse(campo[1]);

            cadeteria = new Cadeteria(columna1, columna2);
        }

    }

    catch (IOException e)
    {
        Console.WriteLine($"error: {e.Message}");
    }
    return cadeteria;
    }

    public override void cargarCadete(Cadeteria cadeteria)
    {
    string filePath = "Cadetes.csv";

    try 
    {
        string[] lineas = System.IO.File.ReadAllLines(filePath);

        foreach (string linea in lineas)
        {
            string[] campo = linea.Split(',');
            int columna1 = int.Parse(campo[0]);
            string columna2 = campo[1];
            string columna3 = campo[2];
            int columna4 = int.Parse(campo[3]);

            Cadete cadete = new Cadete(columna1, columna2, columna3, columna4);
            cadeteria.altaCadete(cadete);    
            
        }
    }

    catch (IOException e)
    {
        Console.WriteLine($"error: {e.Message}");
    }
    }
}

public abstract class AccesoDatosJSON : AccesoDatos
{
    string filePath = "Cadeteria.json";
    Cadeteria cadeteria = new Cadeteria();

    try
    {
        if(File.Exists(filepath))
        {
            var json string = File.ReadAllLines(filepath);
            cadeteria = JsonSerializer()
        }
    }
    catch (System.Exception)
    {
        
        throw;
    }
}



    