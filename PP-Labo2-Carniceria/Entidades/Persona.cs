namespace Entidades
{
    public class Persona
    {
       protected string correo;
       protected string password;

        public Persona(string correo, string password)
        {
            this.correo = correo;
            this.password = password;
        }
    }
}