namespace CRA.clases;

public class Taller
{ 
    public List<Cliente> clientes;
    public List<Vehiculo> vehiculos;
    public List<Empleado> empleados;
    public List<OrdenServicio> ordenesDeServicio;
    public int numeroOrdenActual;
    public int numeroFacturaActual;
 
    public Taller()
    {
        clientes = new List<Cliente>();
        vehiculos = new List<Vehiculo>();
        empleados = new List<Empleado>();
        ordenesDeServicio = new List<OrdenServicio>();
        numeroOrdenActual = 1;
        numeroFacturaActual = 1;
    }

    public void RegistrarCliente(Cliente cliente)
    {
        this.clientes.Add(cliente);
    }

    public void RegistrarVehiculo(Vehiculo vehiculo)
    {
        this.vehiculos.Add(vehiculo);
    }

    public void RegistrarEmpleado(Empleado empleado)
    {
        this.empleados.Add(empleado);
    }
    public Empleado BuscarEmpleado(string id)
    {
        return empleados.Find(e => e.id.Equals(id));
    }
    public Cliente BuscarCliente(string id)
    {
        return clientes.Find(c => c.Id.Equals(id));
    }
    public Vehiculo BuscarVehiculo(string placa)
    {
        return vehiculos.Find(v => v.Placa.Equals(placa));
    }

    public OrdenServicio BuscarOrden(int NroOrden)
    {
        return ordenesDeServicio.Find(o => o.NroOrden == NroOrden);
    }
    public void GenerarOrdenDeServicio()
    {
        Console.Write("Ingrese la cedula del cliente: ");
        string clienteId = Console.ReadLine();
        Console.Write("Ingrese la placa del vehículo: ");
        string vehiculoPlaca = Console.ReadLine();
        Console.Write("Ingrese el diagnostico del cliente: ");
        string diagnosticoCliente = Console.ReadLine();
        Console.Write("Ingrese el id del empleado que va a trabajar: ");
        string empleadoId = Console.ReadLine();

        Empleado empleado = BuscarEmpleado(empleadoId);
        Cliente cliente = BuscarCliente(clienteId);
        Vehiculo vehiculo = BuscarVehiculo(vehiculoPlaca);
        if (cliente == null || vehiculo == null)
        {
            Console.WriteLine("No se pudo generar la orden de servicio");
            return;
        }

        OrdenServicio orden = new OrdenServicio(numeroOrdenActual, DateTime.Now, cliente, vehiculo, diagnosticoCliente);
        orden.AgregarEmpleado(empleado);
        orden.AgregarDiagnosticoExperto();
        orden.GenerarOrdenDeAprobacion(empleadoId);
        ordenesDeServicio.Add(orden);
        numeroOrdenActual++;
    }

    public List<OrdenServicio> ObtenerOrdenesDeServicioPorCliente(string idCliente)
    {
        return ordenesDeServicio.FindAll(orden => orden.Cliente.Id == idCliente);
    }

    public void MostrarOrdenes()
    {
        Console.WriteLine("\n----------------- Órdenes de servicio por cliente -----------------");
        Console.Write("Ingrese la cedula del cliente: ");
        string idCliente = Console.ReadLine();
        List<OrdenServicio> ordenesCliente = ObtenerOrdenesDeServicioPorCliente(idCliente);

        if (ordenesCliente.Count > 0)
        {
            Console.WriteLine($"Órdenes de servicio del cliente con cedula {idCliente}:");
            foreach (var orden in ordenesCliente)
            {
                Console.WriteLine("\n\n-------Datos de la orden-------\n");
                Console.WriteLine($"Nro de orden: {orden.NroOrden}\t Fecha: {orden.FechaOrden}\nCedula cliente: {orden.Cliente.Id}\tNombre CLiente: {orden.Cliente.Nombre}");

                Console.WriteLine("\n-----Datos Vehiculo-------\n");
                Console.WriteLine($"Placa: {orden.Vehiculo.Placa}\tKM: {orden.Vehiculo.Km}\n");

                Console.WriteLine("\n-----Diagnostico Cliente-------\n");
                Console.WriteLine($"Diagnostico: {orden.DiagnosticoCliente}\n");
                Console.WriteLine("\n-----Personal a cargo-------\n");
                foreach (var empleado in orden.PersonalACargo)
                {
                    Console.WriteLine($"Cedula: {empleado.id}\tEmpleado: {empleado.nombre}\tEspecialidad: {empleado.especialidad}\n");

                    foreach (var diagnostico in orden.DiagnosticoExperto)
                    {
                        Console.WriteLine("\n-----Diagnostico empleado-------\n");
                        Console.WriteLine($"Nro cc:{empleado.id}\t Nombre: {empleado.nombre}\n Diagnostico: {diagnostico}\n");
                    }
                }
            }
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine($"El cliente con cedula {idCliente} aun no tiene ordenes de servicio");
        }
    }

    public void MostrarEmpleados()
    {
        Console.WriteLine("--------- Empleados ---------");
        Console.WriteLine("Cedula\tNombre\tCelular\tEspecialidad");
        foreach (Empleado empleado in empleados)
        {
            Console.WriteLine($"{empleado.id}\t{empleado.nombre}\t{empleado.celular}\t{empleado.especialidad}");
        }
        Console.ReadKey();
    }

    public Factura GenerarFactura()
    {
        Console.WriteLine("------------Factura-------------");
        Console.Write("\nIngrese el nùmero de orden: ");
        int nroOrden = int.Parse(Console.ReadLine());

        OrdenServicio orden = BuscarOrden(nroOrden);
        List<ItemAprobacion> itemsAprobados = new List<ItemAprobacion>();
            double subtotalRepuestos = 0;
            foreach (var ordenApro in orden.OrdenesAprobacion)
            {
                foreach (var item in ordenApro.ItemsAprobacion)
                {
                    if (item.Estatus == "A")
                    {
                        subtotalRepuestos += item.ValorTotal;
                        itemsAprobados.Add(item);
                    }
                }
            }

            double ManoObra = subtotalRepuestos * 0.10;
            double subtotal = subtotalRepuestos + ManoObra;
            double iva = subtotal * 0.19;
            double total = subtotal + iva;

            Factura factura = new Factura(nroOrden, numeroFacturaActual, orden.Cliente.Id, subtotal, iva,  ManoObra, total, itemsAprobados);
            numeroFacturaActual++;

            Console.WriteLine("------------------ Factura ---------------");
            Console.WriteLine($"Nro Orden: {factura.NroOrden}\t\tNro Factura: {factura.NroFactura}\n\nCedula Cliente {factura.IdCliente}\n");
            Console.WriteLine("------------------ Detalle Factura ---------------");
            Console.WriteLine("Item\tRepuesto\t\tValor\t\tCantidad\tSubtotal");
            foreach (var item in factura.ItemsAprobados)
            {
                Console.WriteLine($"{item.Item}\t{item.Repuesto}\t\t\t{item.ValorUnitario}\t\t\t{item.Cantidad}\t{item.ValorTotal}");
            }
            Console.WriteLine($"\nSubtotal: {factura.Subtotal}\nIva: {factura.Iva}\nValor Mano de Obra: {factura.ManoObra}\nTotal a Pagar: {factura.Total}");
            return factura;
    }
}