using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        private double monto;

        public Cliente(string correo, string password): base(correo, password)
        {
            this.correo = correo;
            this.password = password;
            listaPersonas.Add(this);
        }
        public Cliente(string correo, string password, double monto):base(correo,password)
        {
             this.monto = monto;
        }
        
        /// <summary>
        /// Busca al cliente dentro de la lista de personas.
        /// </summary>
        /// <param name="correoCliente"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool BuscarCliente(string correoCliente, string pass)
        {
            foreach (Persona persona in listaPersonas)
            {
                if (persona is Cliente cliente && cliente.correo == correoCliente && cliente.password == pass)
                {
                    return true;
                }
            }
            return false;
        }

        public static void HardocdearClientes()
        {
            Cliente c1 = new Cliente("cliente1@gmail.com", "cliente1cliente");
            Cliente c2 = new Cliente("cliente2@gmail.com", "cliente2cliente");
            Cliente c3 = new Cliente("cliente3@gmail.com", "cliente3cliente");
            Cliente c4 = new Cliente("cliente4@gmail.com", "cliente4cliente");


        }
    }
}
