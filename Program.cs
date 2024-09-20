Cadeteria cadeteria = cargarCadeteria();
cadeteria.mostrarNombre();
cargarCadete(cadeteria);
cadeteria.listarCadetes();

cadeteria.altaPedido(1, "sanguche de milanesa", "In process", "Facundo", "Buenos Aires 662", "+5493875060018", "No anda el portero", 1);
cadeteria.altaPedido(2, "Pizza Napolitana", "In process", "Julieta", "Buenos Aires 662", "+54938150974054", "No anda el portero", 2);
cadeteria.altaPedido(3, "Cafe con medialunas", "Picked Up", "Facundo", "San Lorenzo 777", "+5493875060018", "Espera Afuera", 3);
cadeteria.altaPedido(4, "Frappe", "Near Dropoff", "Facundo", "San Lorenzo 777", "+5493875060018", "Espera afuera", 1);

cadeteria.mostrarPedidosCadetes(1);

cadeteria.reasignarOrden(1, 4);
cadeteria.mostrarPedidosCadetes(1);

cadeteria.finalizarPedido(1);
cadeteria.jornalAlCobrar(4);

//cadeteria.reporteDiario();

cadeteria.bajaCadete(1);

cadeteria.listarCadetes();

Cadeteria cargarCadeteria()
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

void cargarCadete(Cadeteria cadeteria)
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
