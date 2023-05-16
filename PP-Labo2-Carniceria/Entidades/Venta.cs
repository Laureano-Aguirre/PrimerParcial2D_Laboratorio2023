using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        private static List<Venta> listaVentas = new List<Venta>();
        private string correoCliente;
        private decimal montoCliente;
        private decimal gastoCliente;

        public Venta(string correoCliente, decimal montoCliente, decimal gastoCliente)
        {
            this.correoCliente = correoCliente;
            this.montoCliente = montoCliente;
            this.gastoCliente = gastoCliente;
        }

        public static List<Venta> ListaVentas { get { return listaVentas; } }
        public string Cliente { get { return correoCliente; } }
        public decimal Monto { get { return montoCliente; } }
        public decimal Gasto { get { return gastoCliente; } }
        public static void HarcodearVentas()
        {
            listaVentas.Add(new Venta("cliente4@gmail.com", 100000, 5000));
            listaVentas.Add(new Venta("cliente3@gmail.com", 5000, 1000));
            listaVentas.Add(new Venta("cliente2@gmail.com", 500, 500));
            listaVentas.Add(new Venta("cliente4@gmail.com", 100000, 50000));
        }

        public bool CargarVenta(Venta venta)
        {
            listaVentas.Add(venta);
            return true;
        }
    }
}
