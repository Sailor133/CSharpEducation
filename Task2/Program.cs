namespace Task2
{
    class Program
    {
        private static void Main()
        {
            StartGameplay();
        }

        private static void StartGameplay()
        {
            int startIndex = -1;
            int direction = -1;
            bool flag = true;
            while (true)
            {
                if (flag)
                    Console.WriteLine("Ход крестиков");
                else
                    Console.WriteLine("Ход ноликов");
                Map.DrowMap();
                Console.WriteLine("Выберете клетку для хода");
                var choice = Console.ReadLine();
                try
                {
                    Map.MakeMove(int.Parse(choice), flag);
                    flag = !flag;
                }
                catch (Exception)
                {
                    Console.WriteLine("Выберете свободное поле");
                }
                if (CheckinWinnings()) break;
                if (CheckingDrawCombination())
                {
                    Console.WriteLine("Ничья!");
                    break;
                }

            }
            Map.DrowMap();
            Console.WriteLine(@"Игра закончилась, хотите сыграть заного? (y\n)");
            if (Console.ReadLine() == "y")
            {
                Map.RefreshMap();
                StartGameplay();
            }
            else return;
        }
        /// <summary>
        /// Провека на ничью
        /// </summary>
        /// <returns></returns>
        private static bool CheckingDrawCombination()
        {
            for (int i = 0; i < Map.GetLenght; i++)
                for (int j = 0; j < Map.GetLenght; j++)
                {
                    if (Map.map[i,j]!='X' || Map.map[i, j] != 'Y') return false;
                }
            return true;
        }

        /// <summary>
        /// Проверка на победну.
        /// </summary>
        /// <param name="startIndex">Начальный элемент победной комбинации</param>
        /// <param name="direction">Победное направление: 0-вертикаль, 1 - горизонталь, 2- диагональ</param>
        /// <returns></returns>
        private static bool CheckinWinnings()
        {
            int startIndex;
            #region Проверка горизонтали и вертикали на выйгрыш
            for (startIndex = 0; startIndex < Map.GetLenght; startIndex++)
            {
                if (Map.map[startIndex, 0] == Map.map[startIndex, 1] && Map.map[startIndex, 1] == Map.map[startIndex, 2]) // Горизонталь
                {
                    Map.WinCoordinates[startIndex, 0] = Map.WinCoordinates[startIndex, 1] = Map.WinCoordinates[startIndex, 2] = 1;
                    return true;
                }
                if (Map.map[0, startIndex] == Map.map[1, startIndex] && Map.map[1, startIndex] == Map.map[2, startIndex]) // Вертикаль
                {
                    Map.WinCoordinates[0, startIndex] = Map.WinCoordinates[1, startIndex] = Map.WinCoordinates[2, startIndex] = 1;
                    return true;
                }
                #endregion               
            }
            #region Проверка диагонали на выйгрыш
            if (Map.map[0, 0] == Map.map[1, 1] && Map.map[1, 1] == Map.map[2, 2])
            {
                Map.WinCoordinates[0, 0] = Map.WinCoordinates[1, 1] = Map.WinCoordinates[2, 2] = 1;
                return true;
            }
            if (Map.map[2, 0] == Map.map[1, 1] && Map.map[1, 1] == Map.map[0, 2])
            {
                Map.WinCoordinates[2, 0] = Map.WinCoordinates[1, 1] = Map.WinCoordinates[0, 2] = 1;
                return true;
            }
            #endregion
            return false;
        }

    }
}
