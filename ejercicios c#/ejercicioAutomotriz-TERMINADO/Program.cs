using ejercicioAutomotriz.clases;
using ejercicioAutomotriz.menus;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Orden> Ordenes = new List<Orden>(); 
        MainMenu menu = new MainMenu();
        int opcion;

        do
        {
            opcion = menu.mostrarMenu();

            switch (opcion)
            {
                case 1:
                    Orden ordenCrear = new Orden();
                    Ordenes.Add(ordenCrear.agregarOrden());
                    ordenCrear.mostrarOrdenes(Ordenes);
                    break;

                case 2:
                    int opcionAgregar;
                    MenuAgregar menuAgregar = new MenuAgregar();
                    do
                    {
                        opcionAgregar = menuAgregar.mostrarMenuAgregar();
                        switch (opcionAgregar)
                        {
                            case 1:
                                Orden ordenBuscar = new Orden();
                                Orden opcionOrden = ordenBuscar.buscarOrdenes(Ordenes);
                                Console.WriteLine(opcionOrden.numeroOrden);
                                Clientes cliente = new Clientes();
                                Clientes nuevoCliente = cliente.agregarCliente();
                                Console.WriteLine(nuevoCliente.nombre);
                                opcionOrden.Clients.Add(nuevoCliente);
                                break;

                            case 2:
                                Orden ordenBuscarOrden = new Orden();
                                Orden opcionOrdenVehi = ordenBuscarOrden.buscarOrdenes(Ordenes);
                                Clientes clienteBuscar = new Clientes();
                                clienteBuscar = clienteBuscar.buscarCliente(opcionOrdenVehi.Clients);
                                Vehiculos vehiculo = new Vehiculos();
                                vehiculo = vehiculo.agregarVehiculo();
                                clienteBuscar.Vehiculoss.Add(vehiculo);
                                break;    

                            case 3:
                                Orden ordenImprimir = new Orden();
                                Orden opcionImprimir = ordenImprimir.buscarOrdenes(Ordenes);
                                Clientes clienteImprimir = new Clientes();
                                clienteImprimir = clienteImprimir.buscarCliente(opcionImprimir.Clients);
                                Vehiculos vehiculoImprimir = new Vehiculos();
                                vehiculoImprimir = vehiculoImprimir.buscarVehiculos(clienteImprimir.Vehiculoss);
                                Empleados empleadosAgregar = new Empleados();
                                empleadosAgregar = empleadosAgregar.agregarEmpleado();
                                vehiculoImprimir.Empleadoss.Add(empleadosAgregar);
                                break;  

                            case 4:
                                Orden ordenRepuestos = new Orden();
                                Orden opcionOrdenRepue = ordenRepuestos.buscarOrdenes(Ordenes);
                                Clientes clienteBuuscar = new Clientes();
                                clienteBuuscar = clienteBuuscar.buscarCliente(opcionOrdenRepue.Clients);
                                Vehiculos vehiculosRepuesto = new Vehiculos();
                                vehiculosRepuesto = vehiculosRepuesto.buscarVehiculos(clienteBuuscar.Vehiculoss);
                                Empleados empleadoBuscar = new Empleados();
                                empleadoBuscar = empleadoBuscar.buscarEmpleado(vehiculosRepuesto.Empleadoss);
                                Repuesto repuestoAgregar = new Repuesto();
                                repuestoAgregar = repuestoAgregar.repuestoAgregar();
                                empleadoBuscar.Repuestoss.Add(repuestoAgregar);
                                break;

                            default:
                                break; 
                        }
                        
                    } while (opcionAgregar != 5);
                    break;

                case 3:
                    Orden ordenBuscarImprimir = new Orden();
                    Orden opcionOrdenImprimir = ordenBuscarImprimir.buscarOrdenes(Ordenes);
                    Clientes clienteBuscarImprimir = new Clientes();
                    clienteBuscarImprimir = clienteBuscarImprimir.buscarCliente(opcionOrdenImprimir.Clients);
                    Vehiculos vehiculoBuscarImprimir = new Vehiculos();
                    vehiculoBuscarImprimir = vehiculoBuscarImprimir.buscarVehiculos(clienteBuscarImprimir.Vehiculoss);
                    Empleados empleadosBuscarr = new Empleados();
                    empleadosBuscarr = empleadosBuscarr.buscarEmpleado(vehiculoBuscarImprimir.Empleadoss);
                    Repuesto repuestoAceptar = new Repuesto();
                    repuestoAceptar = repuestoAceptar.aceptarRepuesto(empleadosBuscarr.Repuestoss);
                    ordenBuscarImprimir.mostrarFactura();
                    ordenBuscarImprimir.mostrarAprobacionRepues();
                    ordenBuscarImprimir.mostrarFacturaFinal();
                    break; 

                default:
                    break;       
            }
        } while(opcion != 4);
    }    
}