using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class StringExtension
    {
        public static int ContarCaracteresEspeciales(string texto)
        {
            char[] caracteresEspeciales = { '*', '@', '#', '$', '&' };
            int contador = 0;

            foreach(char caracter in texto)
            {
                if(caracteresEspeciales.Contains(caracter))
                {
                    contador++;
                }
            }
            return contador;
        }

        public static int ContarMayusculas(string texto)
        {
            int contador = 0;

            foreach (char caracter in texto)
            {
                if(char.IsUpper(caracter))
                {
                    contador++;
                }
            }

            return contador;
        }

        public static int ContarMinusculas(string texto)
        {
            int contador = 0;

            foreach (char caracter in texto)
            {
                if (char.IsLower(caracter))
                {
                    contador++;
                    break;
                }
            }
            return contador;
        }
    }
}
