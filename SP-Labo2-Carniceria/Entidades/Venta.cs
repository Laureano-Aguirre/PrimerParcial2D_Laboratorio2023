using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta: IMostrable
    {
        private static List<Venta> listaVentas = new List<Venta>();
        private string correoCliente;
        private decimal montoCliente;
        private decimal gastoCliente;

        public Venta()
        {
            
        }
        public Venta(decimal montoCliente, decimal gastoCliente)
        {
            this.montoCliente = montoCliente;
            this.gastoCliente = gastoCliente;
        }

        public Venta(string correoCliente, decimal montoCliente, decimal gastoCliente) : this(montoCliente, gastoCliente)
        {
            this.correoCliente = correoCliente;    
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

        public static decimal CalcularPago(decimal monto, decimal costoTotal)
        {
            return monto - costoTotal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            foreach(Venta venta in listaVentas)
            {
                sb.AppendLine($"CORREO CLIENTE: {venta.correoCliente}");
                sb.AppendLine($"MONTO GASTADO: {venta.gastoCliente}");
            }
            return sb.ToString();
        }
    }
}
