using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TheFinalApplication.Models;

namespace TheFinalApplication.Data
{
    class InitializeData
    {
        public static void WriteAllUnits(List<Unit> units, string dataFilePath)
        {
            StringWriter sWriterObject = new StringWriter();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Unit>), new XmlRootAttribute("units"));

            // serialize the list of units to a StringWriter object in XML format
            serializer.Serialize(sWriterObject, units);

            // convert the StringWriter object to a string
            string xmlText = sWriterObject.ToString();

            // write the XML formated string to a file
            using (StreamWriter streamWriter = new StreamWriter(dataFilePath))
            {
                streamWriter.Write(xmlText);
            }
        }
    }
}
