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

        public static char[,] map = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };

        public static void RefreshMap()
        {
            map = new char[3, 3] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        }
        /// <summary>
        /// Вывод поля в консоль.
        /// </summary>
        public static void DrowMap()
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.WriteLine(string.Join("", Enumerable.Repeat("----", map.GetLength(0)))); //Вывод границы строки.
                Console.Write("| "); //Вывод границы поля.
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    if (map[i,j] == 'O') Console.ForegroundColor = ConsoleColor.Red;
                    else if(map[i, j] == 'X') Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(map[i, j]);
                    Console.ForegroundColor = ConsoleColor.White;                   
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
        public static void MakeMove(int value, bool flag)
        {
            int i = (value - 1) / 3;
            int j = (value - 1) % 3;
            if (map[i, j] == 'X' || map[i, j] == 'O') throw new ArgumentException();

            if (flag)
                map[i, j] = 'X';
            else
                map[i, j] = 'O';
        }
    }
}
