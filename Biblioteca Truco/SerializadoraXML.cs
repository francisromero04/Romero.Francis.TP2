using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca_Truco
{
    public static class SerializadoraXML<T> where T : class
    {
        public static void SerializarXML(T objeto, string nombreDeArchivo)
        {
            string path = Environment.CurrentDirectory + "\\" + nombreDeArchivo + ".XML";

            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer serializador = new XmlSerializer(objeto.GetType());
                serializador.Serialize(sw, objeto);
            }
        }

        public static T DeserializarXML(T objeto, string nombreDeArchivo)
        {
            T ret = objeto;

            string path = Environment.CurrentDirectory + "\\" + nombreDeArchivo + ".XML";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    XmlSerializer serializador = new XmlSerializer(objeto.GetType());
                    ret = serializador.Deserialize(sr) as T;
                }
            }
            catch (Exception)
            {

            }

            return ret;
        }
    }
}
