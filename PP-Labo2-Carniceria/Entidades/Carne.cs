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

        
        public Carne(string tipoDeCarne)
        {
            this.tipoDeCarne = tipoDeCarne;
        }

        public Carne(string tipoDeCarne, decimal kilos) : this(tipoDeCarne)
        {
            this.kilos = kilos;
        }

        static public List<Carne> ListaCarnes { get { return carnes; } }
        static public List<Carne> ListaDeCompras { get { return listaDeCompras; } }
        public string TipoDeCarne { get { return this.tipoDeCarne; } }
        public decimal Kilos { get { return this.kilos; } set { kilos = value; } }
        public static void CargarCortes()
        {
            carnes.Add(new Carne("Tira de asado"));
            carnes.Add(new Carne("Colita de cuadril"));
            carnes.Add(new Carne("Bola de lomo"));
            carnes.Add(new Carne("Bife de chorizo"));
            carnes.Add(new Carne("Ojo de bife"));
            carnes.Add(new Carne("Entraña"));
            carnes.Add(new Carne("Tortuguita"));
            carnes.Add(new Carne("Falda"));
        }

        public bool CargarCompra(Carne carne)
        {
            listaDeCompras.Add(carne);
            return true;
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
        public static List<Carne> ObtenerCortes()
        {
            return carnes;
        }

        public static void AsignarPrecioPorKilo()
        {
            foreach (Carne carne in carnes)
            {
                if (carne.tipoDeCarne == "Tira de asado")
                {
                    carne.precioPorKilo = 1800;
                }
                else if (carne.tipoDeCarne == "Colita de cuadril")
                {
                    carne.precioPorKilo = 2400;
                }
                else if (carne.tipoDeCarne == "Bola de lomo")
                {
                    carne.precioPorKilo = 2100;
                }
                else if (carne.tipoDeCarne == "Bife de chorizo")
                {
                    carne.precioPorKilo = 2800;
                }
                else if (carne.tipoDeCarne == "Ojo de bife")
                {
                    carne.precioPorKilo = 3000;
                }
                else if (carne.tipoDeCarne == "Entraña")
                {
                    carne.precioPorKilo = 2900;
                }
                else if (carne.tipoDeCarne == "Tortuguita")
                {
                    carne.precioPorKilo = 1100;
                }
                else if (carne.tipoDeCarne == "Falda")
                {
                    carne.precioPorKilo = 1000;
                }
            }
        }

        public static int CargarPrecioPorKilo(string tipoDeCorte)
        {
            int retorno = 0;

            if (tipoDeCorte == "Tira de asado")
            {
                retorno = 1800;
            }
            else if (tipoDeCorte == "Colita de cuadril")
            {
                retorno = 2400;
            }
            else if (tipoDeCorte == "Bola de lomo")
            {
                retorno = 2100;
            }
            else if (tipoDeCorte == "Bife de chorizo")
            {
                retorno = 2800;
            }
            else if (tipoDeCorte == "Ojo de bife")
            {
                retorno = 3000;
            }
            else if (tipoDeCorte == "Entraña")
            {
                retorno = 2900;
            }
            else if (tipoDeCorte == "Tortuguita")
            {
                retorno = 1100;
            }
            else if (tipoDeCorte == "Falda")
            {
                retorno = 1000;
            }
            return retorno;
        }

        public static int CalcularCosto(decimal kilos, int precioPorKilo)
        {
            decimal precioFinal;

            return (int)(precioFinal = kilos * precioPorKilo);
        }

        public static decimal CalcularNuevoCosto(decimal costoAnterior, decimal costoNuevo)
        {
            return costoAnterior + costoNuevo;
        }

        public static string MostrarCompras()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los cortes seleccionados son: ");
            foreach (Carne carne in listaDeCompras)
            {
                sb.AppendLine($"{carne.tipoDeCarne}");
                sb.AppendLine($"{carne.kilos.ToString()}");
            }

            return sb.ToString();
        }

    }
}

