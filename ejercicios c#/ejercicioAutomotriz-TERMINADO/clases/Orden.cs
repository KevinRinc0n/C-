using ejercicioAutomotriz.clases;

public class Orden : Clientes
{
    public long numeroOrden { get; set; } 
    public long fechaOrden { get; set; }

    public Orden(long numeroOrden, long fechaOrden)
    {
        this.numeroOrden = numeroOrden;
        this.fechaOrden = fechaOrden;
    }

    public Orden(){} 

    public Orden agregarOrden()
    {
        Console.Clear();
        Orden orden = new Orden();
        Console.Write("\nIngrese el numero de la orden: ");
        orden.numeroOrden = long.Parse(Console.ReadLine());
        orden.fechaOrden = DateTimeOffset.Now.ToUnixTimeSeconds();
        return orden;
    }

    public void mostrarOrdenes(List<Orden> Ordenes)
    {
        Console.Clear();
        Console.WriteLine("\nNumero de orden");
        foreach (var ordenn in Ordenes)
        {
            Console.WriteLine($"{ordenn.numeroOrden}");
        }
        Console.ReadKey();
    }

    public Orden buscarOrdenes(List<Orden> Ordenes)
    {
        mostrarOrdenes(Ordenes);
        Console.Write("\nIngresa el numero de orden: ");
        int opcion = int.Parse(Console.ReadLine());
        return Ordenes.Find(orden => orden.numeroOrden == opcion);
    }

    public void mostrarFactura()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("--------------------------- DATOS DE LA ORDEN ----------------------------");
        Console.WriteLine($"         Nro Orden: {this.numeroOrden}                            Fecha orden: {this.fechaOrden}");
        Console.WriteLine($"         Cedula cliente: {this.Clients[0].id}                           Nombre cliente: {this.Clients[0].nombre}");
        Console.WriteLine("--------------------------- DATOS DEL VEHICULO ----------------------------");
        Console.WriteLine($"         Nro placa: {this.Clients[0].Vehiculoss[0].placa}                            Kilometraje: {this.Clients[0].Vehiculoss[0].kilometraje}");
        Console.WriteLine("--------------------------- DIAGNOSTICO DEL CLIENTE ----------------------------");
        Console.WriteLine($"         Diagnostico: {this.Clients[0].Vehiculoss[0].diagnostico} ");
        Console.WriteLine("--------------------------- PERSONAL A CARGO ----------------------------");
        foreach (var empleado in this.Vehiculoss[0].Empleadoss)
        {
            Console.WriteLine($"         Nro cedula: {empleado.id}            Nombre: {empleado.nombre}                Especialidad: {empleado.especialidad}");
            Console.WriteLine("--------------------------- DIAGNOSTICO DEL EXPERTO ----------------------------");
            Console.WriteLine($"         Nro cedula: {empleado.id}            Nombre: {empleado.nombre}                Diagnostico: {empleado.diagnostico}");
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.ReadKey();
    }

    public void mostrarAprobacionRepues()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine($"         Nro Orden: {this.numeroOrden}");
        Console.WriteLine($"         Fecha orden: {this.fechaOrden}");
        Console.WriteLine("      --------------------------- DETALLES DE APROBACION ---------------------");
        foreach (var empleado in this.Vehiculoss[0].Empleadoss)
        {
            Console.WriteLine($"Nro cedula: {empleado.id}");
            Console.WriteLine("ITEM\t\tRESPUESTO\t\tVALOR UNIDAD\t\tCANITDAD\t\tVALOR TOTAL\t\tESTADO");
            foreach (var repuesto in empleado.Repuestoss)
            {
                Console.WriteLine($"{repuesto.item}\t\t{repuesto.nombre}\t\t{repuesto.valor}\t\t{repuesto.cantidad}\t\t{repuesto.valor*repuesto.cantidad}\t\t{repuesto.estado}");
            }
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.ReadKey();
    }

    public void mostrarFacturaFinal()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("------------------------------------ FACTURA ------------------------------------");
        Console.WriteLine($"         Nro Orden: {this.numeroOrden}               Nro Factura: {this.Clients[0].id}");
        Console.WriteLine($"         Cedula cliente: {this.Clients[0].id}");
        Console.WriteLine("-------------------------- DETALLES DE LA FACTURA --------------------------");
        Console.WriteLine("ITEM\t\tRESPUESTO\t\tVALOR UNIDAD\t\tCANITDAD\t\tVALOR TOTAL");

        if (this.Vehiculoss[0].Empleadoss[0].Repuestoss[0].estado == "A")
        {
            decimal totalRepuestos = 0;

            foreach (var repuesto in this.Vehiculoss[0].Empleadoss[0].Repuestoss)
            {
                decimal valorTotalRepuesto = repuesto.valor * repuesto.cantidad;
                totalRepuestos += valorTotalRepuesto;

                Console.WriteLine($"{repuesto.item}\t\t{repuesto.nombre}\t\t{repuesto.valor}\t\t{repuesto.cantidad}\t\t{valorTotalRepuesto}");
            }

            decimal iva = totalRepuestos * 0.19m;
            decimal manoObra = totalRepuestos * 0.10m;
            decimal totalPagar = totalRepuestos + iva + manoObra;

            Console.WriteLine("-------------------------------------------------------------------------------------");
            Console.WriteLine($"El precio total de los repuestos es: {totalRepuestos}");
            Console.WriteLine($"A los repuestos se les agrega un iva del 19%: {iva}");
            Console.WriteLine($"La mano de obra cuesta: {manoObra}");
            Console.WriteLine($"El total a pagar es: {totalPagar}");
        }
        Console.WriteLine("-------------------------------------------------------------------------------------");
        Console.WriteLine("\nEl pago se ha realizado correctamente         ¡GRACIAS POR ELEGIRNOS!");
        Console.ReadKey();
    }
}
