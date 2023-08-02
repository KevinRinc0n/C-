namespace ligaBetplay.Clases
{
    public class Masajista : Persona
    {
        public int añosExperiencia { get; set;}
        public string titulacion { get; set;}

        public Masajista (int id, string nombre, int edad, int añosExperiencia, string titulacion):base(id, nombre, edad)
        {
            this.añosExperiencia = añosExperiencia;
            this.titulacion = titulacion;
        }
    }
}