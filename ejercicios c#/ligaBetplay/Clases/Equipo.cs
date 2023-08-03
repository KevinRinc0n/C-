namespace ligaBetplay.Clases
{
    public class Equipo
    {
        public string nombre { get; set; }

        public List<string> propietarios { get; set; }

        public List<Jugador> jugadores { get; set; }

        public List<Entrenador> entrenadores { get; set; }

        public List<Masajista> masajistas { get; set; }

        public Equipo (string nombre)
        {
            this.nombre = nombre;
            this.propietarios = new List<string>();
            this.jugadores = new List<Jugador>();
            this.entrenadores = new List<Entrenador>();
            this.masajistas = new List<Masajista>();
        }

        public void consultarEquipo()
        {
            
        }
    }
}