using System.ComponentModel;

public class Cadeteria 
{
    private string nombreCadeteria;
    private int telefono;
    private List<Cadete> listadoCadetes;
    private List<Pedido> listadoPedidos;

    public string NombreCadeteria { get => nombreCadeteria; set => nombreCadeteria = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }
    public List<Pedido> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }


    public Cadeteria()
    {

    }

    public Cadeteria(string nombreCadeteria, int telefono)
    {
        this.NombreCadeteria = nombreCadeteria;
        this.Telefono = telefono;
        this.ListadoCadetes = new List<Cadete>();
        this.listadoPedidos = new List<Pedido>();
        
    }

    public void mostrarNombre()
    {
        Console.WriteLine(this.NombreCadeteria);
    }
    public void mostrarTelefono()
    {
        Console.WriteLine(Telefono);
    }
    public void listarCadetes()
    {
        foreach (Cadete c in ListadoCadetes)
        {
            c.listarDatosCadete();
        }

    }

    public void asignarCadeteAPedido(int idPedido, int idCadete)
    {
        foreach(Pedido pedido in listadoPedidos)
        {
            if(idPedido == pedido.Nro)
            {
                pedido.IdCadete = idCadete;
            }else{
                Console.WriteLine("Pedido no encontrado");
            }
        }
    }

    public void finalizarPedido(int nroPedido)
    {
        foreach (Pedido pedido in ListadoPedidos)
        {
            Pedido pedidoFinalizado = listadoPedidos.FirstOrDefault(pedido => pedido.Nro == nroPedido);

            if(pedidoFinalizado != null)
            { 
                listadoPedidos.Remove(pedidoFinalizado);

                Console.WriteLine($"Pedido: {nroPedido} Terminado Exitósamente. Cadete {cadete.Id} ahora tiene {cadete.ContPedidos} pedidos completos");

                return;

            }
        }
    }

    public void pagoPorCadete(int idCadete)
    {
        foreach (Cadete c in ListadoCadetes)
        {
            if(c.Id == idCadete)
            {
                Console.WriteLine("Id Cadete: "+ idCadete);
                Console.WriteLine("\nPago del dia "+ c.jornalAlCobrar());
            }
        }
    }

    public void reporteDiario()
    {
        int sum = 0;
        
        foreach(Cadete c in listadoCadetes)
        {
            Console.WriteLine("\n------------------------------------------");
            Console.WriteLine($"Id Cadete: {c.Id}");
            Console.WriteLine($"Jornal a pagar: {c.jornalAlCobrar()}");
            Console.WriteLine($"Pedidos Completados: {c.ContPedidos}");
            sum = sum + c.jornalAlCobrar();
        }

        Console.WriteLine($"\nTotal de ganancias: {sum}");
    }

    public void mostrarPedidosCadetes(int idCadete)
    {
        foreach(Pedido pedido in listadoPedidos)
        {
            if(pedido.IdCadete == idCadete)
            {
                pedido.listarDatos();
            }
        }
    }
    public void altaCadete(Cadete cadete)
    {
        ListadoCadetes.Add(cadete);
    }
    public void bajaCadete(int idCadete)
    {
        Cadete cadeteBaja = listadoCadetes.FirstOrDefault(c => c.Id == idCadete);

        if(cadeteBaja != null)
        {
            listadoCadetes.Remove(cadeteBaja);
            Console.WriteLine($"Cadete nro: {idCadete} fue dado de baja");
        }else{
            Console.WriteLine($"Cadete nro: {idCadete} no se encuentra");
        }
    }

    public void altaPedido(int nroPedido, string observacion, string estado, string nombre, string direccion, string telefono,
    string referencia, int idCadete)
    {
        Pedido pedido = new Pedido(nroPedido, observacion, estado, nombre, direccion, telefono, referencia);

        listadoPedidos.Add(pedido);
    }

    public void reasignarOrden(int nroPedido, int idNuevoCadete)
    {
        Pedido pedidoAre = null;

        foreach(Pedido p in listadoPedidos)
        {
            if(p.Nro == nroPedido)
            {
                pedidoAre = p;
                break;
            }
            if(pedidoAre != null)
            {
                break;
            }
        }

        if(pedidoAre == null)
        {
            Console.WriteLine("Pedido no encontrado");
            return;
        }

        Cadete cadeteNuevo = listadoCadetes.FirstOrDefault(c => c.Id == idNuevoCadete);

        if(cadeteNuevo != null)
        {
            pedidoAre.IdCadete = idNuevoCadete;
            Console.WriteLine("Pedido reasignado correctamente");
        }else{
            Console.WriteLine("Cadete nuevo no encontrado, pedido reasignado al cadete actual");
        }
    }

    public void listarPedidos()
    {
        foreach(Pedido pedido in listadoPedidos)
        {
            pedido.listarDatos();
        }
    }

    public void eliminarPedido(int nroPedido)
    {
        Pedido pedidoAre = null;
        foreach(Pedido p in listadoPedidos)
        {
            if(p.Nro == nroPedido)
            {
                pedidoAre = p;
                break;
            }
        }
        if(pedidoAre != null)
        {
            listadoPedidos.Remove(pedidoAre);
            Console.WriteLine("El pedido a sido eliminado");
        }
    }

    public Pedido getPedido(int nroPedido)
    {
        Pedido ped = new Pedido();

        foreach(Pedido p in listadoPedidos)
        {
            if(p.Nro == nroPedido)
            {
                ped = p;
            }
        }

        return ped;
    }

    public void borrarPedido(int nroPedido)
    {
        foreach(Pedido p in listadoPedidos)
        {
            if(p.Nro == nroPedido)
            {
                listadoPedidos.Remove(p);
                Console.WriteLine("El Pedido se borró exitosamente");
            }
        }
    } 
        
}