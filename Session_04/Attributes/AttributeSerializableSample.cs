using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Session_04.Attributes
{
    public class AttributeSerializableSample
    {
        public AttributeSerializableSample()
        {
            Person person = new("Raffy", "Ang", 29);
            var serializer = new DataContractSerializer(person.GetType());
        }

        [DataContract]
        public class Person
        {
            public Person(string firstName, string lastName, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
            }

            [DataMember]
            public string FirstName { get; set; }
            [DataMember]
            public string LastName { get; set; }
            [DataMember]
            public int Age { get; set; }

        }
    }
}
