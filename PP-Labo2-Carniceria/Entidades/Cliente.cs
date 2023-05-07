using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente:Persona
    {
        private decimal monto;

        public Cliente(string correo, string password): base(correo, password)
        {
            this.correo = correo;
            this.password = password;
            monto= 0;
            listaPersonas.Add(this);
        }

        public Cliente(string correo, string password,decimal monto):base(correo, password)
        {
            this.monto = monto;
        }
        public decimal Monto { get { return this.monto; } set { monto = value; } }
        public string Correo { get { return this.correo; }}
        public string Password { get { return this.password; }}

        /// <summary>
        /// Busca al cliente dentro de la lista de personas.
        /// </summary>
        /// <param name="correoCliente"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool ValidarCliente(string correoCliente, string pass)
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

        /// <summary>
        /// Busca al cliente, apsandole los parametros correo y clave, y si lo encuentra, devuelve al objeto de tipo cliente
        /// </summary>
        /// <param name="correo"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Cliente BuscarCliente(string correo, string pass)
        {
            foreach (Persona persona in listaPersonas)
            {
                if (persona is Cliente cliente && cliente.correo == correo && cliente.password == pass)
                {
                    return cliente;
                }
            }
            return null;
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
