using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows;
using System.IO;
using System.Text.Json;

namespace Entidades
{
    [XmlInclude(typeof(Carne))]
    [XmlInclude(typeof(ETipoDePago))]
    public class Serializadora<T>
    {
        private static string ruta = AppDomain.CurrentDomain.BaseDirectory;

        public static void EscribirXml(List<T> lista)
        {
            string nombreArchivo = @"\Serializador.xml";

            string completa = ruta + nombreArchivo;

            try
            {
                using (StreamWriter sw = new StreamWriter(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    xmlSerializer.Serialize(sw, lista);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public static List<T> LeerXml()
        {
            string nombreArchivo = @"\Serializador.xml";

            string completa = ruta + nombreArchivo;

            List<T> listaAux = null;

            try
            {
                using (StreamReader sr = new StreamReader(completa))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    listaAux = (List<T>)xmlSerializer.Deserialize(sr);
                }
                return listaAux;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public static void EscribirJson(List<T> lista)
        {
            string nombreArchivo = @"\SerializadorJson.json";

            string completa = ruta + nombreArchivo;

            try
            {
                string stringJson = JsonSerializer.Serialize(lista);
                File.WriteAllText(completa, stringJson);
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }

        public static List<T> LeerJson()
        {
            string nombreArchivo = @"\SerializadorJson.json";

            string completa = ruta + nombreArchivo;

            List<T> listaAux = null;

            try
            {
                string strJson = File.ReadAllText(completa);
                listaAux = (List<T>)JsonSerializer.Deserialize<List<T>>(strJson);

                return listaAux;
            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
    }
}
