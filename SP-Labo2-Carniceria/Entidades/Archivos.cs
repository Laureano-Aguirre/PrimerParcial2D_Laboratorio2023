using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Archivos
    {
        private static string ruta = AppDomain.CurrentDomain.BaseDirectory;

        public static void Escribir()
        {
            string nombreArchivo = @"\Historial ventas.txt";

            string completa = ruta + nombreArchivo;

            try
            {
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    Venta ventaAux = new Venta();

                    sw.WriteLine(ventaAux.Mostrar());
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el archivo {completa}");
            }    
        }
    }
}
