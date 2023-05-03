using System.Text;

namespace Entidades
{
    public class Persona
    {
       protected string correo;
       protected string password;
       protected static List<Persona> listaPersonas = new List<Persona>();

        public Persona(string correo, string password)
        {
            this.correo = correo;
            this.password = password;   
        }


        
        public string MostrarPersona()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("");

            return sb.ToString();
        }
    }
}