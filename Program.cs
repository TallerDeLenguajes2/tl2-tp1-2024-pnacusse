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


