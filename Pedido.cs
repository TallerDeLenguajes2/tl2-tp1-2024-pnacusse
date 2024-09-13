public class Pedido
{
    private int nro;
    private string obs;
    private string estado;
    private Cliente cliente;

    public int Nro { get => nro; set => nro = value; }
    public string Obs { get => obs; set => obs = value; }
    public string Estado { get => estado; set => estado = value; }
    public Cliente Cliente { get => cliente; set => cliente = value; }

    public Pedido(int nro, string obs, string estado, string nombre, string direccion, string telefono, string referencia)
    {
        this.Nro = nro;
        this.Obs = obs;
        this.Estado = estado;
        this.Cliente = new Cliente(nombre, direccion, telefono, referencia);
    }

    public Pedido()
    {

    }

    public void verDireccionCadete()
    {
        
    }
    public void verDatosCliente()
    {
        
    }
    
    
}