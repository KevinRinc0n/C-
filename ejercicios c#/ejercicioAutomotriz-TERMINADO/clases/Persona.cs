namespace ejercicioAutomotriz.clases
{
    public class Persona
    {
        public long id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public long numero { get; set; }

        public Persona(long id, string nombre, string apellido, long numero)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numero = numero;
        }
        public Persona (){}
    }
}