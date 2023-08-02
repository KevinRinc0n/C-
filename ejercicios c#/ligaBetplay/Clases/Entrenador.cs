namespace ligaBetplay.Clases
{
    public class Entrenador : Persona
    {
        public int codigoFederacion {get; set; }
        public string especialidad {get; set; }

        public Entrenador(int id, string nombre, int edad, int codigoFederacion, string especialidad):base(id, nombre, edad)
        {
            this.codigoFederacion = codigoFederacion;
            this.especialidad = especialidad;
        }

    }
}