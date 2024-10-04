using System.Text.Json;

public abstract class AccesoDatos
{
    protected AccesoDatos()
    {

    }

    public abstract Cadeteria cargarCadeteria();

    public abstract void cargarCadete(Cadeteria cadeteria);

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

public abstract class AccesoDatosJson : AccesoDatos
{
    public AccesoDatosJson() : base()
    {

    }
    public override Cadeteria cargarCadeteria()
    {
        string filePath = "Cadeteria.json";
        Cadeteria cadeteria = new Cadeteria();

        try
        {
            if(File.Exists(filepath))
            {
                var json = File.ReadAllLines(filepath);
                cadeteria = JsonSerializer(Desearialize<Cadeteria>(json));
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
        catch (IOException e)
        {
        
            Console.WriteLine($"Error : {e.Message}");
        }

        return cadeteria;

    }
    
    public override void cargarCadete(Cadeteria cadeteria)
    {
        if (cadeteria == null)
        {
            Console.WriteLine("Error");
            return;
        }
        string filePath = "Cadetes.json";

        try
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"'{filePath}' no encontrado");
                return;
            }
        
            string json = File.ReadAllText(filePath);
        
            List<Cadete> cadetes = JsonSerializer.Deserialize<List<Cadete>>(json);

            if (cadetes == null || cadetes.Count == 0)
            {
                Console.WriteLine("Error");
                return;
            }

            foreach (Cadete cadete in cadetes)
            {
                Cadeteria.altaCadete(cadete);
            }
        
            Console.WriteLine($"Cadetes Cargados");
        }
        catch (IOException e)
        {
            Console.WriteLine($"Error : {e.Message}");
        }
    }
}






    