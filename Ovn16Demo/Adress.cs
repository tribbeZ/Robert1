using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn16Demo
{
    class Adress : ContactDetails
    {
        public string street;
        public string city;

        public Adress(string type, string street, string city) : base(type)
        {
            this.street = street;
            this.city = city;
        }

        public override void SetValue(string city)
        {
            this.city = city;
        }
    }
}
