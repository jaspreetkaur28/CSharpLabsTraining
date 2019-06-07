using lab_72_LINQ_Join;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace lab_93_deserialise_xml_to_cList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> myObjects = new List<Product>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<MyObject>));
            XmlReader reader = XmlReader.Create("objects.xml");
            myObjects = (List<MyObject>)serializer.Deserialize(reader);

            // now you can perform operations on your list of MyObject objects,
            // no manual XML parsing necessary.

            Console.WriteLine("Press <ENTER> key to exit.");
            Console.ReadLine();

        }
    }
}
