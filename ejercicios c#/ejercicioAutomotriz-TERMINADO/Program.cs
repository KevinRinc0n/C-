using CRA.menus;
using CRA.clases;

internal class Program 
{
    private static void Main(string[] args)
    {
        Taller taller = new Taller();
        MenuPrincipal menuPrincipal = new MenuPrincipal();
        int opcion;

        do
        {
            opcion = menuPrincipal.MostrarMenu();
            switch (opcion)
            {
                case 1:
                    int opcionRegistrar;
                    MenuRegistrar menuRegistrar = new MenuRegistrar();
                    do
                    {
                        opcionRegistrar = menuRegistrar.MostrarMenuRegistrar();
                        switch (opcionRegistrar)
                        {
                            case 1:
                                Cliente cliente = new Cliente();
                                taller.RegistrarCliente(cliente.agregarCliente());
                                Console.WriteLine("\nCliente registrado correctamente");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.WriteLine("Ingrese la cedula del cliente: ");
                                string idClienteVehiculo = Console.ReadLine();
                                Cliente clienteVehiculo = taller.BuscarCliente(idClienteVehiculo);
                                Vehiculo vehiculo = new Vehiculo();
                                vehiculo = vehiculo.agregarVehiculo();
                                taller.RegistrarVehiculo(vehiculo);
                                clienteVehiculo.Vehiculos.Add(vehiculo);
                                Console.WriteLine("\nVehículo registrado correctamente");
                                Console.ReadKey();
                                break;
                            case 3:
                                Empleado empleado = new Empleado();
                                taller.RegistrarEmpleado(empleado.agregarEmpleado());
                                Console.WriteLine("\nEmpleado registrado correctamente\n");
                                taller.MostrarEmpleados();
                                break;    
                        }
                    } while (opcionRegistrar != 4);
                    break;
                case 2:
                    int opcionOrden;
                    MenuOrdenServ menuOrdenServ = new MenuOrdenServ(); 
                    do
                    {
                        opcionOrden = menuOrdenServ.MostrarMenu();
                        switch (opcionOrden)
                        {
                            case 1:
                                taller.GenerarOrdenDeServicio();
                                Console.ReadKey();
                                break;
                            case 2:
                                taller.MostrarOrdenes();
                                break;
                            case 3:
                                Console.WriteLine("Ingrese el número de orden: ");
                                int idClienteOrden = int.Parse(Console.ReadLine());
                                OrdenServicio ordenServicio = taller.BuscarOrden(idClienteOrden);
                                Console.WriteLine("Ingrese la cedula del empleado: ");
                                string idEmpleadoOrden = Console.ReadLine();
                                Empleado empleadoOrden = taller.BuscarEmpleado(idEmpleadoOrden);
                                ordenServicio.PersonalACargo.Add(empleadoOrden);
                                ordenServicio.AgregarDiagnosticoExperto();
                                Console.ReadKey();
                                break; 
                            case 4:
                                Console.Write("Ingrse el número de Orden de Servicio: ");
                                int idOrdenAprobacion = int.Parse(Console.ReadLine());
                                OrdenServicio ordenServicioAprobacion = taller.BuscarOrden(idOrdenAprobacion);
                                ordenServicioAprobacion.MostrarOrdenesAprobacion();
                                Console.ReadKey();
                                break;   
                            default:
                                break;
                        }
                    } while (opcionOrden != 5);
                    break;
                case 3:
                    Factura factura = taller.GenerarFactura();
                    Console.ReadKey();
                    break;
            }
        } while (opcion != 4);
    }
}