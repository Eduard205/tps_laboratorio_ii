using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    public class ClaseSerializadora<T>
    {
        static string ruta;
        static ClaseSerializadora()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta += @"\Archivo-Serializacion";
        }

        /// <summary>
        /// Serializa un objeto en tipo Xml
        /// </summary>
        /// <param name="lista"></param>
        /// <exception cref="Exception"></exception>
        public static void Escribir(List<T> lista) 
        {
            string rutaCompleta = ruta + @"\Serializacion_ListaClientes_Xml";

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamWriter sw = new StreamWriter(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    xmlSerializer.Serialize(sw, lista);
                }
            }
            catch (Exception) 
            {
                throw new Exception($"Error en el archivo {rutaCompleta}");
            }
        }

        /// <summary>
        /// deserializa un objeto de tipo Xml
        /// </summary>
        /// <returns>Retorna el objeto deserializado</returns>
        /// <exception cref="Exception"></exception>
        public static List<T> Leer()
        {
            string rutaCompleta = ruta + @"\Serializacion_ListaClientes_Xml";

            List<T> listaAux = null;

            try
            {
                if (!Directory.Exists(ruta))
                {
                    Directory.CreateDirectory(ruta);
                }

                using (StreamReader sr = new StreamReader(rutaCompleta))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<T>));
                    listaAux = (List<T>)xmlSerializer.Deserialize(sr);
                }
                return listaAux;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el archivo {rutaCompleta}", ex);
            }
        }
    }
}
