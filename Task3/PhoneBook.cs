using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task3
{
    /// <summary>
    /// Класс телефонной книги с паттерном синглтон.
    /// </summary>
    internal class PhoneBook
    {
        public static PhoneBook instance;

        private PhoneBook(string name, string phoneNuber)
        {}
        public static PhoneBook GetInstance(string name, string phoneNuber)
        {
            if (instance == null)
                instance = new PhoneBook(name, phoneNuber);
            return instance;
        }
        /// <summary>
        /// Добавление пользователя в json файл.
        /// </summary>
        public static void Add(List<Abonent> abonent)
        {
            string json = JsonSerializer.Serialize(abonent);
            File.WriteAllText(@"PhoneBook.json", json);
        }
        /// <summary>
        /// Читает файл json и возвращает List<Abonent>.
        /// </summary>
        public static List<Abonent> Read() 
        {
            var abonents = File.ReadAllText(@"PhoneBook.json");
            var playerList = JsonSerializer.Deserialize<List<Abonent>>(abonents);
            return playerList;
        }
    }
}
