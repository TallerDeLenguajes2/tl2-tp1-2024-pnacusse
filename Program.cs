

Cadeteria cadeteria = cargarCadeteriaCsvJson();

cadeteria.altaPedido(1, "sanguche de milanesa", "In process", "Facundo", "Buenos Aires 662", "+5493875060018", "No anda el portero", 1);
cadeteria.altaPedido(2, "Pizza Napolitana", "In process", "Julieta", "Buenos Aires 662", "+54938150974054", "No anda el portero", 2);
cadeteria.altaPedido(3, "Cafe con medialunas", "Picked Up", "Facundo", "San Lorenzo 777", "+5493875060018", "Espera Afuera", 3);
cadeteria.altaPedido(4, "Frappe", "Near Dropoff", "Facundo", "San Lorenzo 777", "+5493875060018", "Espera afuera", 1);

/*cadeteria.mostrarPedidosCadetes(1);*/

cadeteria.reasignarOrden(1, 4);
/*cadeteria.mostrarPedidosCadetes(1);*/s

cadeteria.finalizarPedido(1);
cadeteria.jornalAlCobrar(4);

//cadeteria.reporteDiario();

cadeteria.bajaCadete(1);

cadeteria.listarCadetes();

Cadeteria cargarCadeteriaCsvJson()
{
    Cadeteria cadeteria = new Cadeteria();
    Console.WriteLine("Cargar datos Cadeteria----------\nSelect: \n 1) cargar datos desde csv\n 2) cargar datos desde Json");
    int option = int.Parse(Console.ReadLine());

    while (option < 1 || option > 2)
    {
        Console.WriteLine("Seleccionar una opcion valida");
        option = int.Parse(Console.ReadLine());
    }

    if (option == 1)
    {
        AccesoDatosCSV accesoDatosCSV = new AccesoDatosCSV();
        Console.WriteLine("Carga Cadeteria desde csv");
        cadeteria = accesoDatosCSV.cargarCadeteria();
        cadeteria.mostrarNombre();
        cadeteria.mostrarTelefono();
        
        Console.WriteLine("Carga cadetes desde csv");
        accesoDatosCSV.cargarCadete(cadeteria);
        cadeteria.listarCadetes();
    }
    else
    {
        AccesoDatosJson accesoDatosJson = new AccesoDatosJson();
        Console.WriteLine("Carga Cadeteria desde json");
        cadeteria = accesoDatosJson.cargarCadeteria();
        cadeteria.mostrarNombre();
        cadeteria.mostrarTelefono();
        
        Console.WriteLine("Carga cadetes desde json");
        accesoDatosJson.cargarCadete(cadeteria);
        cadeteria.listarCadetes();
    }

    return cadeteria;
}


