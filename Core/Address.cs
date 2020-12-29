using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Address : IAddress
    {
        public Address(string street, int number)
        {
            Street = street;
            Number = number;
        }

        public string Street { get; set; }
        public int Number { get; set; }

        public string FullAddress() => $"{Street}, {Number}";
        
    }
}
