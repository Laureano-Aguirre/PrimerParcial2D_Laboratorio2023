using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public sealed class Vendedor : Persona
    {
        public enum ETipoDePago
        {
            Efectivo,
            Credito,
            Debito
        }

        public Vendedor(string correo, string password) : base(correo, password)
        {
            this.correo = correo;
            this.password = password;
            listaPersonas.Add(this);
        }
        /// <summary>
        /// Busca el vendnedor dentro de la lista de personas, comprobando el correo y contrasenia
        /// </summary>
        /// <param name="correoCliente"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool BuscarVendedor(string correoCliente, string pass)
        {
            foreach (Persona persona in listaPersonas)
            {
                if (persona is Vendedor vendedor && vendedor.correo == correoCliente && vendedor.password == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public static string MostrarMetodoDePago()
        {
            string mensaje = "Tipos de pago disponibles:\n";
            foreach (Vendedor.ETipoDePago tipo in Enum.GetValues(typeof(Vendedor.ETipoDePago)))
            {
                mensaje += tipo.ToString() + "\n";
            }
            return mensaje;
        }

        public static void HardcodearVendedores()
        {
            Vendedor v1 = new Vendedor("vendedor1@gmail.com", "vendedor1vendedor");
            Vendedor v2 = new Vendedor("vendedor2@gmail.com", "vendedor2vendedor");
            Vendedor v3 = new Vendedor("vendedor3@gmail.com", "vendedor3vendedor");
            Vendedor v4 = new Vendedor("vendedor4@gmail.com", "vendedor4vendedor");
        }

        public override string MostrarPersona(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            if(persona is Vendedor vendedor)
            {
                sb.AppendLine($"Correo: {vendedor.correo}");
            }

            return sb.ToString();
        }
    }
}
