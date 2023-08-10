namespace CRA.clases;
using CRA.clases;

public class OrdenServicio
{ 
    public int NroOrden { get; set; }
    public DateTime FechaOrden { get; set; }
    public Cliente Cliente { get; set; }
    public Vehiculo Vehiculo { get; set; }
    public string DiagnosticoCliente { get; set; }
    public List<Empleado> PersonalACargo { get; set; }  
    public List<string> DiagnosticoExperto { get; set; } 
    public List<OrdenAprobacion> OrdenesAprobacion { get; set; } 

    public OrdenServicio(int nroOrden, DateTime fechaOrden, Cliente cliente, Vehiculo vehiculo, string diagnosticoCliente)
    {
        this.NroOrden = nroOrden;
        this.FechaOrden = fechaOrden;
        this.Cliente = cliente;
        this.Vehiculo = vehiculo;
        this.DiagnosticoCliente = diagnosticoCliente;
        this.PersonalACargo = new List<Empleado>();
        this.DiagnosticoExperto = new List<string>();
        this.OrdenesAprobacion = new List<OrdenAprobacion>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        this.PersonalACargo.Add(empleado);
    }

    public void AgregarDiagnosticoExperto()
    {
        List<string> diagnosticosPreestablecidos = new List<string>
    {
        "Falla en el motor",
        "Problema con la batería",
        "Fuga de líquido de frenos",
        "Problema de suspensión",
        "Problema de frenos"
    };
        Random random = new Random();
        int indexDiagnostico = random.Next(0, diagnosticosPreestablecidos.Count);
        string diagnostico = diagnosticosPreestablecidos[indexDiagnostico];
        this.DiagnosticoExperto.Add(diagnostico);
    }

    public void GenerarOrdenDeAprobacion(string empleadoId)
    {
        Empleado empleado = PersonalACargo.Find(empleado => empleado.id == empleadoId);
        OrdenAprobacion ordenAprobacion = new OrdenAprobacion(NroOrden, FechaOrden, empleado.id);
        OrdenesAprobacion.Add(ordenAprobacion);
    }

    public void MostrarOrdenesAprobacion()
    {
        Console.WriteLine("------- Ordene aprobación -------");
        foreach (var orden in OrdenesAprobacion)
        {
            Console.WriteLine($"Nro Orden: {orden.NroOrden}\tFecha: {orden.Fecha}\nCedula Empleado: {orden.IdEmpleado}");
            Console.WriteLine("\n-------- Detalle Aprobación --------\n");
            Console.Write("Ingrese el numero de item del repuesto:");
            string itemN = Console.ReadLine();
            Console.Write("Ingrese el nombre del repuesto:");
            string repuesto = Console.ReadLine();
            Console.Write("\nIngrese el valor del repuesto:");
            double valorU = double.Parse(Console.ReadLine());
            Console.Write("\nIngrese la cantidad del repuesto:");
            int cantidad = int.Parse(Console.ReadLine());
            Console.Write("\nIngrese el estado del repuesto ('A' para aprobado o 'R' para rechazarlo): ");
            string estado = Console.ReadLine();
            ItemAprobacion item = new ItemAprobacion(itemN, repuesto, valorU, cantidad);
            orden.AgregarItemAprobacion(item);   
            if (estado.ToUpper() != "A" && estado.ToUpper() != "R")
            {
                Console.WriteLine("invalido");
                return;
            } else{
                if(estado.ToUpper() == "A"){
                    item.Estatus = "A";
                } else{
                    item.Estatus = "R";
                }
            }
        }
    }
}