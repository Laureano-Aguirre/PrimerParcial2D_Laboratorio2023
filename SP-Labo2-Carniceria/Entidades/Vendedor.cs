using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    public sealed class Vendedor : Persona, IMostrable
    {
        private int id;
        public Vendedor(string correo, string password) : base(correo, password)
        {     
            this.correo = correo;
            this.password = password;
        }

        public Vendedor(int id, string correo , string password) :this(correo, password)
        {
            this.id = id;
        }

        public string Correo { get { return this.correo; } set { correo = value; } }
        public string Password { get { return this.password; } set { password = value; } }

        public int Id { get { return this.id; } }
        /// <summary>
        /// Busca el vendnedor dentro de la lista de personas, comprobando el correo y contrasenia
        /// </summary>
        /// <param name="correoCliente"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool BuscarVendedor(List<Vendedor> lista, Vendedor vendedorAux)
        {
            foreach (Vendedor vendedor in lista)
            {
                if (vendedor.correo == vendedorAux.correo && vendedor.password == vendedorAux.password)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Muestra los metodos de pago, recorriendo el Enum
        /// </summary>
        /// <returns></returns>
        public static string MostrarMetodoDePago()
        {
            string mensaje = "Tipos de pago disponibles:\n";
            foreach (ETipoDePago tipo in Enum.GetValues(typeof(ETipoDePago)))
            {
                mensaje += tipo.ToString() + "\n";
            }
            return mensaje;
        }

        //public static void HardcodearVendedores()
        //{
        //    Vendedor v1 = new Vendedor( "vendedor1@gmail.com", "Vendedor1vendedor*");
        //    Vendedor v2 = new Vendedor("vendedor2@gmail.com", "Vendedor2vendedor$");
        //    Vendedor v3 = new Vendedor("vendedor3@gmail.com", "Vendedor3vendedor#");
        //    Vendedor v4 = new Vendedor("vendedor4@gmail.com", "Vendedor4vendedor*");
        //}

        public override string MostrarPersona(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            if(persona is Vendedor vendedor)
                sb.AppendLine($"{vendedor.correo}");
            

            return sb.ToString();
        }

        public static Vendedor DevolverVendedor(List<Vendedor> lista, string correo)
        {
            foreach (Vendedor vendedor in lista)
            {
                if (vendedor.correo == correo)
                {
                    return vendedor;
                }
            }
            return null;
        }

        public static bool BuscarPorCorreo(List<Vendedor> lista, string correo)
        {
            foreach(Vendedor vendedor in lista)
            {
                if(vendedor.correo == correo)
                {
                    return true;
                }
            }
            return false;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"{correo}");

            return sb.ToString(); 
        }
    }
}
