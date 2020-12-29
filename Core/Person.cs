using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Person
    {
        public Person(string firstName, string lastName, IAddress address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAddress Address { get; set; }

        public virtual string FullName () => $"{FirstName} {LastName}";

        public virtual string UpperFullName() => FullName().ToUpperInvariant();
        public virtual string NameAndAddres() => $"{FullName()} - {Address.FullAddress()}";

    }
}
