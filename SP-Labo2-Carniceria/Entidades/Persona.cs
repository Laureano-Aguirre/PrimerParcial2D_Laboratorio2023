using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
       protected string correo;
       protected string password;
       protected static List<Persona> listaPersonas = new List<Persona>();

        public Persona(string correo, string password)
        {
            this.correo = correo;
            this.password = password;   
        }

        public static List<Persona> ListaPersonas { get { return listaPersonas; } }

        public abstract string MostrarPersona(Persona persona);

    }
}