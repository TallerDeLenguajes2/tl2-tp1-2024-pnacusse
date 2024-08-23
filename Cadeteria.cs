using System.ComponentModel;

public class Cadeteria 
{
    private string nombreCadeteria;
    private int telefono;
    private List<Cadete> listadoCadetes;

    public Cadeteria(string nombreCadeteria, int telefono, List<Cadete> listadoCadetes)
    {
        this.nombreCadeteria = nombreCadeteria;
        this.telefono = telefono;
        this.listadoCadetes = listadoCadetes;
    }

    public void mostrarNombre()
    {
        Console.WriteLine(this.nombreCadeteria);
    }
    public void mostrarTelefono()
    {
        Console.WriteLine(telefono);
    }
    public void listarCadetes()
    {
        Console.WriteLine(listadoCadetes);

    }
    public void altaCadete(Cadete cadete, List<Cadete> lista)
    {
        lista.Add(cadete);
    }
    public void bajaCadete(Cadete cadete, List<Cadete> lista)
    {
        lista.Remove(cadete);
    }
        
    public void modificarCadete(Cadete cadete, List<Cadete> lista)
    {
        
    } 
}