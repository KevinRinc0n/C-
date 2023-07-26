class Program
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public List<string> Hobbies { get; set; } = new List<string>();
    }

    public static Dictionary<double, Usuario> usuarios = new Dictionary<double, Usuario>();

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
                    agregar();
                    break;

                case 2:
                    verUsuario();
                    break;

                case 3:
                    verTodosUsuarios();
                    break;

                case 4:
                    eliminar();
                    break;

                case 5:
                    Console.WriteLine("\nAdios!!\n");
                    break;

                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

        } while (opcion != 5);
    }

    static void menu()
    {
        Console.WriteLine("\n---------------------------------- Sistema de registro de Usuarios ----------------------------------\n");
        Console.WriteLine("1. AGREGAR USUARIO");
        Console.WriteLine("2. VER USUARIO");
        Console.WriteLine("3. VER TODOS LOS USUARIOS");
        Console.WriteLine("4. ELIMINAR USUARIO");
        Console.WriteLine("5. SALIR");
    }

    static int pedirOpcion()
    {
        Console.WriteLine("\nELIGE UNA OPCIÓN: ");
        int respuesta = Convert.ToInt32(Console.ReadLine());
        return respuesta;
    }

    static void agregar()
    {
        Console.WriteLine("\nIngresa tu número de indentificación: ");
        double id = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nIngresa tu nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("\nIngresa tu edad: ");
        string edad = Console.ReadLine();
        Console.WriteLine("\nIngresa tus hobbies (separa cada hobby por una coma): ");
        string hobbiesInput = Console.ReadLine();
        string[] hobbies = hobbiesInput.Split(',');

        Usuario nuevoUsuario = new Usuario
        {
            Nombre = nombre,
            Edad = edad
        };

        foreach (string hobby in hobbies)
        {
            nuevoUsuario.Hobbies.Add(hobby.Trim());
        }

        usuarios.Add(id, nuevoUsuario);
    }

    static void verUsuario()
    {
        Console.WriteLine("Ingresa la identificación del usuario: ");
        double identificacion = Convert.ToDouble(Console.ReadLine());
        if (usuarios.ContainsKey(identificacion))
        {
            Usuario usuario = usuarios[identificacion];
            Console.WriteLine($"Identificación: {identificacion}  nombre: {usuario.Nombre}  edad: {usuario.Edad}  hobbies: {string.Join(", ", usuario.Hobbies)}");
        }
        else
        {
            Console.WriteLine("ESTE USUARIO NO EXISTE!");
        }
    }

    static void verTodosUsuarios()
    {
        foreach (KeyValuePair<double, Usuario> usuario in usuarios)
        {
            Console.WriteLine($"Identificación: {usuario.Key}  nombre: {usuario.Value.Nombre}  edad: {usuario.Value.Edad}  hobbies: {string.Join(", ", usuario.Value.Hobbies)}");
        }
    }

    static void eliminar()
    {
        Console.WriteLine("Ingresa la identificación del usuario a eliminar: ");
        double id = Convert.ToDouble(Console.ReadLine());
        if (usuarios.ContainsKey(id))
        {
            usuarios.Remove(id);
            Console.WriteLine("USUARIO ELIMINADO EXITOSAMENTE!");
        }
        else
        {
            Console.WriteLine("ESTE USUARIO NO EXISTE!");
        }
    }
}