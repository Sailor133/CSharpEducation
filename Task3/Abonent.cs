using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Abonent
    {
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public Abonent(string name, string phoneNuber) 
        { 
            Name = name;
            PhoneNumber = phoneNuber;
        }
    }
}
