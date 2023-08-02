namespace ligaBetplay.Clases
{
    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public int id { get; set; }

        public Persona (string nombre, int edad, int id)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.id = id;
        }
    } 
}