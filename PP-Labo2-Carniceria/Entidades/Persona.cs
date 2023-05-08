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

        public abstract string MostrarPersona(Persona persona);

    }
}