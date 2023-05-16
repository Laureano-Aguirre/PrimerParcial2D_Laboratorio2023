using System.Text;

namespace Entidades
{
    public class Carne
    {
        private static List<Carne> carnes = new List<Carne>();
        private static List<Carne> listaDeCompras = new List<Carne>();
        private string tipoDeCarne;
        private int precioPorKilo;
        private decimal kilos;
        private decimal stock;

        
        public Carne(string tipoDeCarne, int precioPorKilo)
        {
            this.tipoDeCarne = tipoDeCarne;
            this.precioPorKilo = precioPorKilo;
        }

        public Carne(string tipoDeCarne, int precioPorKilo, decimal stock) : this(tipoDeCarne, precioPorKilo)
        {
            this.stock = stock;
        }
        public Carne(string tipoDeCarne, decimal kilos)
        {
            this.tipoDeCarne= tipoDeCarne;
            this.kilos = kilos;
        }

        static public List<Carne> ListaCarnes { get { return carnes; } }
        static public List<Carne> ListaDeCompras { get { return listaDeCompras; } }
        public string TipoDeCarne { get { return this.tipoDeCarne; } }
        public decimal Kilos { get { return this.kilos; } set { kilos = value; } }
        public decimal Stock { get { return this.stock; } set { stock = value; } }
        public int PrecioPorKilo { get { return this.precioPorKilo; } set { precioPorKilo = value; } }
        public static void CargarCortes()
        {
            carnes.Add(new Carne("Tira de asado", 1800, 20));
            carnes.Add(new Carne("Colita de cuadril", 2400, 20));
            carnes.Add(new Carne("Bola de lomo", 2100, 20));
            carnes.Add(new Carne("Bife de chorizo", 2800, 20));
            carnes.Add(new Carne("Ojo de bife", 3000, 20));
            carnes.Add(new Carne("Entraña", 2900, 20));
            carnes.Add(new Carne("Tortuguita", 1100, 20));
            carnes.Add(new Carne("Falda", 1000, 20));
        }

        public bool CargarCompra(Carne carne)
        {
            listaDeCompras.Add(carne);
            return true;
        }

        public static void LimpiarListaCompras()
        {
            listaDeCompras.Clear();
        }
        public static string MostrarCortes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los cortes de carne son: ");
            foreach (Carne carne in carnes)
            {
                sb.AppendLine(carne.tipoDeCarne);
            }

            return sb.ToString();
        }

        public static int CargarPrecioPorKilo(string corte)
        {
            int retorno = 0;

            foreach (Carne carne in carnes)
            {
                if(carne.tipoDeCarne == corte)
                {
                    retorno = carne.precioPorKilo;
                }
            }
            return retorno;
        }

        public static int CalcularCosto(decimal kilos, int precioPorKilo)
        {
            decimal precioFinal;

            return (int)(precioFinal = kilos * precioPorKilo);
        }

        public static string MostrarCompras()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("PRODUCTOS: ");
            foreach (Carne carne in listaDeCompras)
            {
                sb.AppendLine($"-{carne.kilos.ToString()}KG {carne.tipoDeCarne}");
            }
            return sb.ToString();
        }

        public static decimal CalcularPago(decimal monto, decimal costoTotal)
        {
            return monto - costoTotal;
        }

        public static bool CargarTipoDeCorte(string corte, int precioPorKilo, decimal stock)
        {
            ListaCarnes.Add(new Carne(corte, precioPorKilo, stock));

            return true;
        }
    }
}

