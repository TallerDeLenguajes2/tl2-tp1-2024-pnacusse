public class Cadete
{
    private const int pedidoEntregado = 500;
    private int id;
    private string nombre;
    private string direccion;
    private int telefono;
    private List<Pedido> pedidos;
    private int contPedidos;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
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
        this.Pedidos = new List<Pedido>();
        this.contPedidos = 0;
    }

    public int jornalAlCobrar()
    {
        return(this.contPedidos * 500);
    }
    public void listarDatosCadete()
    {
        Console.WriteLine("------------------------");
        Console.WriteLine($"Cadete {Id}");
        Console.WriteLine($"Nombre:{Nombre}");
        Console.WriteLine($"Dirección:{Direccion}");
        Console.WriteLine($"Telefono:{Telefono}");

    }

    public void agregarPedido(Pedido pedido)
    {
        pedidos.Add(pedido);
    }
    public void listarPedidos()
    {
        Console.WriteLine("Pedidos: ", Pedidos);
    }

    public void eliminarPedido(int nroPedido)
    {
        Pedido pedidoAre = null;
        foreach(Pedido p in this.Pedidos)
        {
            if(p.Nro == nroPedido)
            {
                pedidoAre = p;
                break;
            }
        }
        if(pedidoAre != null)
        {
            Pedidos.Remove(pedidoAre);
            Console.WriteLine("El pedido a sido eliminado");
        }
    }

    public Pedido getPedido(int nroPedido)
    {
        Pedido ped = new Pedido();

        foreach(Pedido p in this.Pedidos)
        {
            if(p.Nro == nroPedido)
            {
                ped = p;
            }
        }

        return ped;
    }

    public void terminarPedido(int nroPedido)
    {
        foreach(Pedido p in this.Pedidos)
        {
            if(p.Nro == nroPedido)
            {
                ContPedidos++;
                Pedidos.Remove(p);
                Console.WriteLine("El Pedido se completó exitosamente");
            }
        }
    }
}