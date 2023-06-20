using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows;
using System.IO;

namespace Entidades
{
    public class Serializadora
    {
        private static string ruta = AppDomain.CurrentDomain.BaseDirectory;


        public static void Escribir(List<Carne> carnes)
        {
            string nombreArchivo = @"\ProductosSerializador.xml";

            string completa = ruta + nombreArchivo;

            try
            {
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Carne>));
                    xmlSerializer.Serialize(sw, carnes);
                }
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
