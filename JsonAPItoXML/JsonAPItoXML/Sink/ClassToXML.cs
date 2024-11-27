using JsonAPItoXML.model.Factories;
using JsonAPItoXML.Model;
using JsonAPItoXML.Model.Factories;
using System.Xml.Serialization;

namespace JsonAPItoXML.Sink
{
    public class ClassToXML
    {
        public static void Execute<T>(List<T> genericList)
        {
            XMLFactory factory = new XMLFactory();
            factory.CreateArchive(genericList);
        }

    }
}
