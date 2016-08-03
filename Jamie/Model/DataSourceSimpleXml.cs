using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Jamie.Model
{
    public class DataSourceSimpleXml<T>
    {

        internal static string GetOneDriveUserFolder()
        {
            RegistryKey subkey;


            subkey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\OneDrive");

            if (subkey == null)
                return "";

            return subkey.GetValue("UserFolder").ToString();
        }

        public static void Serialize(T list, string filepath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextWriter writer = new StreamWriter(string.Format(@"{0}{1}", GetOneDriveUserFolder(), filepath)))
            {
                serializer.Serialize(writer, list);
            }
        }

        public static T Deserialize(string filepath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StreamReader(string.Format(@"{0}{1}", GetOneDriveUserFolder(), filepath)))
            {
                return (T)serializer.Deserialize(reader);
            }
        }

    }


}
