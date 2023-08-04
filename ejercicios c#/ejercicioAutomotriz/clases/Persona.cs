namespace ejercicioAutomotriz.clases
{
    public class Persona
    {
        public int id {get; set;}
        public string nombre {get; set;}
        public string apellido {get; set;}
        public int numero {get; set;}

        public Persona (int id, string nombre, string apellido, int numero)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.numero = numero;
        }
    }
}