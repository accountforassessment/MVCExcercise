using System.IO;
using System.Xml.Serialization;

namespace MVCExcercise.Utilities
{
    public static class XMLParserUtility
    {
        public static T Deserialize<T>(string xmlString, string rootNode)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T),new XmlRootAttribute(rootNode));
            using (StringReader reader = new StringReader(xmlString))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}