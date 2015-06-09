using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace SerializeJson
{
    class Program
    {
        static void Main(string[] args)
        {

            var stream = File.ReadAllText("personJson.txt");
            var application= JsonConvert.DeserializeObject<Application>(stream);

            var persons=application.Persons; 

            foreach (var person in persons)
            {
                Console.WriteLine(string.Format("Name {0}",person.Name));
                Console.WriteLine(string.Format("Dob {0}", person.Dob));
                Console.WriteLine(string.Format("Desgination {0}", person.Designation));

                var addresses = person.Address;
                foreach (var address in addresses)
                {
                    Console.WriteLine(string.Format("Address {0}", address.Address1));
                    Console.WriteLine(string.Format("Address {0}", address.Address2));
                    Console.WriteLine(string.Format("Address {0}", address.Address3));
                    Console.WriteLine(string.Format("City {0}", address.City));
                }
                
            }

        }
    }
}
