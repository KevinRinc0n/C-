namespace ligaBetplay.Clases
{
    public class Jugador : Persona
    {
        int dorsal { get; set; }
        string posicion { get; set; }
        int nivelHabilidad { get; set; }
        string piernaHabil { get; set; }

        public Jugador (int id, int edad, string nombre, int dorsal, string posicion, int nivelHabilidad, string piernaHabil):base(id,nombre,edad)
        {
            this.dorsal = dorsal;
            this.posicion = posicion;
            this.nivelHabilidad = nivelHabilidad;
            this.piernaHabil = piernaHabil;
        }
    }
}  