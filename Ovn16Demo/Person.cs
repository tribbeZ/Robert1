using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn16Demo
{
    class Person
    {
        public string firstName;
        public string lastName;
        public List<ContactDetails> details = new List<ContactDetails>();

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return $"Firstname: {firstName}, Lastname: {lastName}";
        }
    }
}
