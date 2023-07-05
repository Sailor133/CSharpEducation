using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    static class Map
    {

        private static char[,] map = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        /// <summary>
        /// Вывод поля в консоль.
        /// </summary>
        public static void DrowMap()
        {
            int counter = 1;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.WriteLine(string.Join("", Enumerable.Repeat("----", map.GetLength(0)))); //Вывод границы строки.
                Console.Write("| "); //Вывод границы поля.
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(string.Join("", Enumerable.Repeat("----", map.GetLength(0)))); //Вывод границы строки.
        }
        /// <summary>
        /// Добавление на игровое поле знака.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="mark"></param>
        public static void MakeMove(int value, char choice)
        {
            int i = (value - 1) / 3;
            int j = (value - 1) % 3;
            map[i, j] = choice;
        }
    }
}
