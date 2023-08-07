using LigaBetPlay.Classes;
class Equipo
{
    public string nombre { get; set; }
    public List<string> propietarios { get; set; }
    public List<Jugador> jugadores { get; set; } 
    public List<Masajista> masajistas { get; set; }
    public List<Entrenador> entrenadores { get; set; }

    public Equipo(string nombre)
    {
        this.nombre = nombre;
        this.propietarios = new List<string>();
        this.jugadores = new List<Jugador>();
        this.masajistas = new List<Masajista>();
        this.entrenadores = new List<Entrenador>();
    }
    public Equipo()
    {
        this.propietarios = new List<string>();
        this.jugadores = new List<Jugador>();
        this.masajistas = new List<Masajista>();
        this.entrenadores = new List<Entrenador>();
    }

    public Equipo agregarEquipo()
    {
        Equipo equipo = new Equipo();
        Console.Write("Ingrese el nombre del equipo :");
        equipo.nombre = Console.ReadLine();
        Console.Write("Ingrese cantidad de propietarios del equipo :");
        int cantidad = int.Parse(Console.ReadLine());
        for (int i = 0; i < cantidad; i++)
        {
            Console.Write("Ingrese el nombre del propietario: ");
            string propietario = Console.ReadLine();
            equipo.propietarios.Add(propietario);
        }
        return equipo;
    }

    public Equipo buscarEquipo(List<Equipo> equiposDeLiga)
    {
        Console.WriteLine("Nombre");
        foreach (var equipo in equiposDeLiga)
        {
        Console.WriteLine($"{equipo.nombre}");
        }
        Console.ReadKey();

        Console.WriteLine("ingrese el nombre del Equipo: ");
        string opcion = Console.ReadLine();

        Equipo equipoSeleccionado = equiposDeLiga.Find(equipo => equipo.nombre.Equals(opcion));

        Console.WriteLine($"Nombre: {equipoSeleccionado.nombre}\nCantidad de Propietarios: {equipoSeleccionado.propietarios.Count}\nCantidad de Jugadores: {equipoSeleccionado.jugadores.Count}\nCantidad de Entrenadores: {equipoSeleccionado.entrenadores.Count}\nCantidad de Masajistas: {equipoSeleccionado.masajistas.Count}");
        Console.ReadKey();
        return equipoSeleccionado;

    }

    public void ListarJugadores(List<Jugador> jugadores)
    {
        Console.WriteLine($"------------------ Jugadores {this.nombre} ------------------");
        Console.WriteLine("#\t\tNombre\t\tEdad\t\tCiudad\t\tDorsal\t\tPosicion\t\tHabilidad\t\tPierna Habil");
        foreach (var jugador in jugadores)
        {
            Console.WriteLine($"{jugador.id}\t\t{jugador.nombre}\t\t{jugador.edad}\t\t{jugador.ciudadOrigen}\t\t{jugador.Dorsal}\t\t{jugador.Posicion}\t\t{jugador.NivelHabilidad}\t\t{jugador.PiernaHabil}");
        }
        Console.ReadKey();
    }

    public void ListarDelanteros(List<Jugador> jugadores)
    {
        Console.WriteLine($"------------------ Delanteros {this.nombre} ------------------");
        Console.WriteLine("#\t\tNombre\t\tEdad\t\tCiudad\t\tDorsal\t\tPosicion\t\tHabilidad\t\tPierna Habil");
        foreach (var jugador in jugadores)
        {
            if (jugador.Posicion.ToUpper().Equals("DELANTERO"))
            {
                 Console.WriteLine($"{jugador.id}\t\t{jugador.nombre}\t\t{jugador.edad}\t\t{jugador.ciudadOrigen}\t\t{jugador.Dorsal}\t\t{jugador.Posicion}\t\t{jugador.NivelHabilidad}\t\t{jugador.PiernaHabil}");
            }
           
        }
        Console.ReadKey();
    }

    public void ListarEntrenadores(List<Entrenador> entrenadores)
    {
        Console.WriteLine($"------------------ Entrenadores {this.nombre} ------------------");
        Console.WriteLine("#\t\tNombre\t\tEdad\t\tCiudad\t\tcod.Federacion\t\tEspecialidad");
        foreach (var entrenador in entrenadores)
        {
            Console.WriteLine($"{entrenador.id}\t\t{entrenador.nombre}\t\t{entrenador.edad}\t\t{entrenador.ciudadOrigen}\t\t{entrenador.codFederacion}\t\t{entrenador.especialidad}");
        }
        Console.ReadKey();
    }
}
