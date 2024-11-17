using JsonAPItoXML.Model;
using JsonAPItoXML.Model.Factories;
using System.Xml.Serialization;

namespace JsonAPItoXML.Sink
{
    internal class ClassToXML : IArchiveFactory
    {

        public void CreateArchive<T>(List<T> genericList)
        {
            string name = typeof(T).Name + "s.xml";
            string filePath = Path.Combine(ProjectConfig.DirectoryXML, name);

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, genericList);
            }
        }

    }
}
