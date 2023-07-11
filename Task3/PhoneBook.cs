using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    internal class PhoneBook
    {
        public static PhoneBook instance;

        private PhoneBook(Abonent abonent)
        {}
        public static PhoneBook GetInstance(string name, string phoneNuber)
        {
            if (instance == null)
                instance = new PhoneBook(name, phoneNuber);
            return instance;
        }
    }
}
