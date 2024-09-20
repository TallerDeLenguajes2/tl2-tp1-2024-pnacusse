public class Pedido
{
    private int nro;
    private string obs;
    private string estado;
    private Cliente cliente;

    private int idCadete;

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public string Estado { get => estado; set => estado = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }
    public int IdCadete { get => idCadete; set => idCadete = value; }

    public Pedido(int nro, string obs, string estado, string nombre, string direccion, string telefono, string referencia)
    {
        this.Nro = nro;
        this.Obs = obs;
        this.Estado = estado;
        this.Cliente = new Cliente(nombre, direccion, telefono, referencia);
        this.idCadete = 0;
    }

    public Pedido()
    {

    }

    public void listarDatos()
    {
        Console.WriteLine("\n-------------------------------------");
        Console.WriteLine($"Nro: {Nro}");
        Console.WriteLine($"Observación: {Obs}");
        Console.WriteLine($"Estado: {Estado}");
        
    }
    public void verDireccionCadete()
    {
        
    }
    public void verDatosCliente()
    {
        
    }
    
    
}