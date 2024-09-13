using System.ComponentModel;

public class Cadeteria 
{
    private string nombreCadeteria;
    private int telefono;
    private List<Cadete> listadoCadetes;

    public string NombreCadeteria { get => nombreCadeteria; set => nombreCadeteria = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    public List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

    public Cadeteria()
    {

    }

    public Cadeteria(string nombreCadeteria, int telefono)
    {
        this.NombreCadeteria = nombreCadeteria;
        this.Telefono = telefono;
        this.ListadoCadetes = new List<Cadete>();
        
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

    public void finalizarPedido(int nroPedido)
    {
        foreach (Cadete cadete in ListadoCadetes)
        {
            Pedido pedidoFinalizado = cadete.Pedidos.FirstOrDefault(pedido => pedido.Nro == nroPedido);

            if(pedidoFinalizado != null)
            {
                cadete.ContPedidos += 1;
                
                cadete.Pedidos.Remove(pedidoFinalizado);

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

    public void mostrarPedidosCadetes()
    {
        foreach(Cadete c in listadoCadetes)
        {
            c.listarPedidos();
        }
    }

    public void mostrarPedidosCadetes(int idCadete)
    {
        foreach(Cadete c in listadoCadetes)
        {
            if(c.Id == idCadete)
            {
                c.listarPedidos();
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

        foreach(Cadete c in listadoCadetes)
        {
            if(c.Id == idCadete)
            {
                c.agregarPedido(pedido);
            }
        }
    }

    public void reasignarOrden(int nroPedido, int idNuevoCadete)
    {
        Pedido pedidoAre = null;
        Cadete cadeteActual = null;

        foreach(Cadete c in listadoCadetes)
        {
            foreach(Pedido p in c.Pedidos)
            {
                if(p.Nro == nroPedido)
                {
                    pedidoAre = p;
                    cadeteActual = c;
                    break;
                }
            }

            if(pedidoAre != null)
            {
                break;
            }
        }

        if(pedidoAre == null || cadeteActual == null)
        {
            Console.WriteLine("Pedido o Cadete no encontrado");
            return;
        }

        cadeteActual.eliminarPedido(pedidoAre.Nro);

        Cadete cadeteNuevo = listadoCadetes.FirstOrDefault(c => c.Id == idNuevoCadete);

        if(cadeteNuevo != null)
        {
            cadeteNuevo.agregarPedido(pedidoAre);
            Console.WriteLine("Pedido reasignado correctamente");
        }else{
            cadeteActual.agregarPedido(pedidoAre);
            Console.WriteLine("Cadete nuevo no encontrado, pedido reasignado al cadete actual");
        }
    }
        
}