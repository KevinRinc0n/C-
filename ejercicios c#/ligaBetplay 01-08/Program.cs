class Program
{
    public static Dictionary<string, Federacion> Liga = new Dictionary<string, Federacion>();

    static void Main()

    {
        int opcion;

        do
        {
            menu();
            opcion = pedirOpcion();

            switch (opcion)
            {
                case 1:
                    agregarPlantel();
                    break;
                case 2:
                    consultarDatos();
                    break;
                case 3:
                    break;        
            }

        } while (opcion != 3);
    }

    static void menu()
    {
        Console.WriteLine("\n---------------------------------- Liga Betplay ----------------------------------\n");
        Console.WriteLine("1. REGISTRO PLANTEL");
        Console.WriteLine("2. CONSULTA DE DATOS");
        Console.WriteLine("3. SALIR");
    }

    static int pedirOpcion()
    {
        Console.Write("\nIngresa la opción que deseas realizar: ");
        int respuesta = converter.ToInt32(Console.ReadLine());
        return respuesta;
    }

    static void agregarPlantel()
    {
        Console.Clear();
        Console.WriteLine("\n---------------------------------- REGISTRO PLANTEL ----------------------------------\n");
        Console.WriteLine("1.1 REGISTRO EQUIPO");
        Console.WriteLine("1.2 REGISTRO JUGADOR");
        Console.WriteLine("1.3 REGISTRO ENTRENADOR");
        Console.WriteLine("1.4 REGISTRO MASAJISTA");
        Console.WriteLine("1.5 VENTA DE JUGADOR");
        Console.WriteLine("1.6 REGRESAR AL MENU PRINCIPAL");

        do
        {
            opcionRegister = pedirOpcionRegister();

            switch (opcionRegister)
            {
                case 1:
                    agregarPlantel();
                    break;
                case 2:
                    consultarDatos();
                    break;
                case 3:
                    break;        
            }

        } while (opcion != 3);

        static double pedirOpcionRegister()
        {
            Console.Write("\nIngresa la opción que deseas realizar: ");
            double respuesta = converter.ToDouble(Console.ReadLine());
            return respuesta;
        }
    }

    static void consultarDatos()
    {
        Console.Clear();
        Console.WriteLine("\n---------------------------------- CONSULTA DE DATOS ----------------------------------\n");
        Console.WriteLine("1.1 LISTAR JUGADORES POR EQUIPO");
        Console.WriteLine("1.2 BUCAR LOS DELANTEROS POR EQUIPO");
        Console.WriteLine("1.3 BUCAR CUERPO DE ENTRENADORES POR EQUIPO");
        Console.WriteLine("1.4 REGRESAR AL MENU PRINCIPAL");
    }
}