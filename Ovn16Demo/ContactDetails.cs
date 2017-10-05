using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovn16Demo
{
    class ContactDetails
    {
        public string type;
        public string value;

        public ContactDetails(string type)
        {
            this.type = type;
        }

        public ContactDetails(string type, string value)
        {
            this.type = type;
            this.value = value;
        }

        public virtual void SetValue(string value)
        {
            this.value = value;
        }
    }
}
