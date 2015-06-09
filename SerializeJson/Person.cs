using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SerializeJson
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public string Designation { get; set; }
        public IList<Address> Address { get; set; }
    }
}
