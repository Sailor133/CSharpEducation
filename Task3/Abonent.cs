using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /// <summary>
    /// Класс абонента.
    /// </summary>
    internal class Abonent
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public Abonent(string name, string phoneNuber) 
        { 
            Name = name;
            PhoneNumber = phoneNuber;
        }
    }
}
