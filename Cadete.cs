public class Cadete
{
    private const int pedidoEntregado = 500;
    private int id;
    private string nombre;
    private string direccion;
    private int telefono;
    private int contPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public int ContPedidos { get => contPedidos; set => contPedidos = value; }

    public Cadete()
    {
        
    }

    public Cadete(int id, string nombre, string direccion, int telefono)
    {
        Nombre = nombre;
        Id = id;
        Direccion = direccion;
        Telefono = telefono;
        this.contPedidos = 0;
    }

    public void listarDatosCadete()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine($"Cadete {Id}");
        Console.WriteLine($"Nombre:{Nombre}");
        Console.WriteLine($"Dirección:{Direccion}");
        Console.WriteLine($"Telefono:{Telefono}");

    }

}