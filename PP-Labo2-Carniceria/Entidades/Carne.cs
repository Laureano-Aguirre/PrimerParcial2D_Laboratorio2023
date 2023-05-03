using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carne
    {
        static List<Carne> carnes = new List<Carne>();
        string tipoDeCarne;


        public Carne(string tipoDeCarne)
        {
            this.tipoDeCarne = tipoDeCarne;
        }

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

        public static string MostrarCortes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los cortes de carne son: ");
            foreach(Carne carne in carnes)
            {
                sb.AppendLine(carne.tipoDeCarne);
            }

            return sb.ToString();
        }
        public static List<Carne> ObtenerCortes()
        {
            return carnes;
        }

    }
}
