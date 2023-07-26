class Program {
    public static Dictionary<string,string> contactos = new Dictionary<string,string>();

    static void Main() {
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    Agregar();
                    break;
                case 2:
                    Mostrar();
                    break;
                case 3:
                    MarcarFavorito();
                    break;
                case 4:
                    Eliminar();
                    break;
                case 5:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 5);
    }

    static void MostrarMenu() {
        Console.WriteLine("-------- LIBRETA TELEFÓNICA --------");
        Console.WriteLine("Menú:");
        Console.WriteLine("1. AGREGAR");
        Console.WriteLine("2. MOSTRAR");
        Console.WriteLine("3. MARCAR COMO IMPORTANTE");
        Console.WriteLine("4. ELIMINAR");
        Console.WriteLine("5. Salir");
    }

    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Agregar() {
        Console.WriteLine("Ingresa el nombre del contacto: ");
        string ? nombre = Console.ReadLine();
        Console.WriteLine("Ingresa el telefono del contacto: ");
        string ? telefono = Console.ReadLine();
        contactos.Add(nombre, telefono);
    }

    static void Mostrar() {
        foreach (KeyValuePair<string,string> contacto in contactos) {
            Console.WriteLine($"Nombre: {contacto.Key}   Número: {contacto.Value} ");
        }
    }

    static void MarcarFavorito() {
        Mostrar();
        Console.WriteLine("Ingresa el nombre del contacto a guardar como favorito: ");
        string ? favorito = Console.ReadLine();
        if(contactos.ContainsKey(favorito)){
            contactos[favorito] = contactos[favorito] + " FAVORITO";
            Console.WriteLine("El contacto se ha guardado como favorito");

        }else{
            Console.WriteLine("Este contacto no exite");
        }
    }

    static void Eliminar() {
        Console.WriteLine("Ingresa el nombre del contacto que deseas eliminar: ");
        string ? nombre = Console.ReadLine();
        if(contactos.ContainsKey(nombre)){
            contactos.Remove(nombre);
            Console.WriteLine("Contacto eliminado correctamente");
        }else{
            Console.WriteLine("Este contacto no exite");
        }
    }
}