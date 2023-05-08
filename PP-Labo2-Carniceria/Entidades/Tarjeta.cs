using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tarjeta
    {

        private long numero;
        private string nombreTitular;
        private DateTime fechaVto;
        static List<Tarjeta> tarjetas = new List<Tarjeta>();

        public Tarjeta(long numero, string nombreTitular, DateTime fechaVto)
        {
            this.numero = numero;
            this.nombreTitular = nombreTitular;
            this.fechaVto = fechaVto;
            CargarTarjeta(this);
        }

        public static List<Tarjeta> Tarjetas { get { return tarjetas; } }
        public long  Numero { get { return this.numero; } }
        public string Nombre { get { return this.nombreTitular; } }
        public void CargarTarjeta(Tarjeta tarjeta)
        {
            tarjetas.Add(tarjeta);
           
        }
        public string MostrarDatos(string nombreTitular, long numero)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"NOMBRE: {nombreTitular}");
            sb.AppendLine($"NUMERO: {numero.ToString()}");

            return sb.ToString();
        }

        public decimal AgregarRecarga(decimal costoParcial)
        {
            decimal recargaTarjeta;
            recargaTarjeta = costoParcial * 0.05m;
            return recargaTarjeta;
        }
    }
}
