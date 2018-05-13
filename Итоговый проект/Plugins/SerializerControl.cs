using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Итоговый_проект.Plugins
{
    class SerializerControl
    {
        public XmlSerializer serializer = new XmlSerializer(typeof(Person));
        public string SerializeObject(Object ob)
        {
            MemoryStream stream = new MemoryStream();
            serializer.Serialize(stream, ob);
            return Convert.ToBase64String(stream.ToArray());
        }
        
        public Object DeSerializeObject(string str)
        {
            MemoryStream stream = new MemoryStream();
            Person newPerson = (Person)serializer.Deserialize(stream);
            return newPerson;
        }
    }
    
}
