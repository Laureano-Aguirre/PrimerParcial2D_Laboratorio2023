using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Cliente : Persona
    {
        private decimal monto;
        private decimal gasto;
        private int id;
        private List<Carne> listaDeCompras;

        public Cliente(string correo, string password) : base(correo, password)
        {

            this.correo = correo;
            this.password = password;
            monto = 0;
            gasto = 0;
            listaDeCompras = new List<Carne>();
        }

        public Cliente(string correo, string password,decimal monto, decimal gasto):base(correo, password)
        {
            this.monto = monto;
            this.gasto = gasto;
            listaDeCompras = new List<Carne>();
        }

        public Cliente(int id, string correo, string password,decimal monto, decimal gasto) : base(correo, password)
        {
            this.password = password;
            this.id = id;
            this.correo = correo;
            this.monto= monto;
            this.gasto = gasto;
            listaDeCompras = new List<Carne>();
        }

        public decimal Monto { get { return this.monto; } set { monto = value; } }
        public string Correo { get { return this.correo; }}
        public string Password { get { return this.password; } set { password = value; } }
        public decimal Gasto { get { return this.gasto; } set { gasto = value; } }

        public List<Carne> ListaDeCompras { get => listaDeCompras; }
        public int Id { get => id; set => id = value; }


        /// <summary>
        /// Busca al cliente dentro de la lista de personas.
        /// </summary>
        /// <param name="correoCliente"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public static bool ValidarCliente(List<Cliente> lista, Cliente clienteAux)
        {
            foreach (Cliente cliente in lista)
            {
                if (cliente.correo == clienteAux.correo && cliente.password == clienteAux.password)
                {
                    return true;
                }
            }
            return false;
        }

        public override string MostrarPersona(Persona persona)
        {
            StringBuilder sb = new StringBuilder();
            
            if(persona  is Cliente cliente)
            sb.AppendLine($"CORRE DEL CLIENTE: {cliente.correo}");

            return sb.ToString();
        }

        /// <summary>
        /// Recprre la lista de personas, y trae a los que son de tipo Cliente
        /// </summary>
        /// <returns></returns>
        public static string ListarClientes(List<Cliente> lista)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Cliente cliente in lista)
            {
                    sb.AppendLine($"Correo: {cliente.correo} - Monto: {cliente.monto}");
            }

            return sb.ToString();
        }

        public static string MostrarCompra(Cliente cliente)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PRODUCTOS: ");
            foreach (Carne carne in cliente.ListaDeCompras)
            {

                sb.AppendLine($"-{carne.Kilos.ToString()}KG {carne.TipoDeCarne}");
            }
            return sb.ToString();
        }     

        public static string MostrarVentas()
        {

            StringBuilder sb = new StringBuilder();

            foreach (Persona persona in listaPersonas)
            {
                if (persona is Cliente cliente)
                {
                    if (cliente.ListaDeCompras.Count > 0)
                    {
                        sb.AppendLine($"Correo: {cliente.correo}");
                        sb.AppendLine(MostrarCompra(cliente));
                    }
                }
            }
            return sb.ToString();

        }

        public bool CargarCompra(Carne carne)
        {
            if (monto >= carne.PrecioPorKilo)
            {
                listaDeCompras.Add(carne);
                monto -= carne.PrecioPorKilo;
                gasto += carne.PrecioPorKilo;
                return true;
            }
            return false;
        }

        public static void LimpiarListaCompras(Cliente cliente)
        {
            if(cliente.ListaDeCompras.Count > 0)
            {
                cliente.ListaDeCompras.Clear();
            }         
        }

        public static string MostrarClientes(List<Cliente> clientes)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Cliente cliente in clientes)
            {
                sb.AppendLine($"ID: {cliente.id}");
                sb.AppendLine($"CORREO: {cliente.correo}");
                sb.AppendLine($"MONTO: {cliente.monto}");
                sb.AppendLine($"GASTO: {cliente.gasto}");
            }

            return sb.ToString();
        }

        public static bool BuscarPorCorreo(List<Cliente> lista, string correo)
        {
            foreach(Cliente cliente in lista)
            {
                if(cliente.correo == correo)
                {
                    return true;
                }
            }
            return false;
        }

        public static Cliente DevolverCliente(List<Cliente> lista, string correo)
        {
            foreach(Cliente cliente in lista)
            {
                if (cliente.correo == correo)
                {
                    return cliente;
                }
            }
            return null;
        }

    }
}
