using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace Serialization
{
    class DataContractSerializationTest
    {
        static void Main_1(string[] args)
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(Person));
            Person p = new Person
            {
                Name = "khushal",
                Age = 1,
                Addresses = new List<Address>()
                    {
                                new Address() { city = "Bangalore", state = "Karnataka", zipCode = "560085" },
                         new Address() { city = "Bangalore1", state = "Maharashtra", zipCode = "560085" }
                    }
            };
            using (Stream fs = File.OpenWrite("Person.xml"))
            {
                ser.WriteObject(fs, p);
                fs.Flush();
            }

            using (XmlWriter writer = XmlWriter.Create("PersonUsingXml.xml", new XmlWriterSettings() { Indent = true, Encoding = Encoding.ASCII }))
            {
                ser.WriteObject(writer, p);
                writer.Flush();
            }

            MemoryStream stream = new MemoryStream();
            using (XmlDictionaryWriter writer = XmlDictionaryWriter.CreateBinaryWriter(stream))
            {
                ser.WriteObject(writer, p);
            }

            Console.WriteLine(Encoding.ASCII.GetString(stream.GetBuffer()));
            Console.ReadLine();
        }

        [DataContract(Namespace = "http://Amruth.Rayabagi/V1")]
        public class Person
        {
            [DataMember]
            public string Name;

            [DataMember]
            public int Age;

            [DataMember]
            public List<Address> Addresses;

            [OnSerializing]
            public void OnSerializingAttribute(StreamingContext context)
            {
                Name = Guid.NewGuid().ToString();
            }

            [OnSerialized]
            public void OnSerialized(StreamingContext context)
            {
                Name = Guid.NewGuid().ToString();
            }
        }

        [DataContract(Namespace = "http://Amruth.Rayabagi/V1")]
        public class Address
        {
            [DataMember(EmitDefaultValue = false, Name = "Zip", Order = 1)]
            public string zipCode;
            [DataMember]
            public string city;
            [DataMember]
            public string state;
        }
    }
}
