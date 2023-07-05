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
            }
            Console.WriteLine(@"Игра закончилась, хотите сыграть заного? (y\n)");
            if (Console.ReadLine() == "y")
            {
                Map.RefreshMap();
                StartGameplay();
            }
            else return;
        }

        private static bool CheckinWinnings()
        {
            #region Проверка горизонтали и вертикали на выйгрыш
            for (int i = 0; i < Map.map.GetLength(0); i++)
            {
                if (Map.map[i, 0] == Map.map[i, 1] && Map.map[i, 1] == Map.map[i, 2]) return true;
                if (Map.map[0, i] == Map.map[1, i] && Map.map[1, i] == Map.map[2, i]) return true;
            }
            #endregion
            #region Проверка диагонали на выйгрыш
            if (Map.map[0, 0] == Map.map[1, 1] && Map.map[1, 1] == Map.map[2, 2])
            {
                return true;
            }
            if (Map.map[2, 0] == Map.map[1, 1] && Map.map[1, 1] == Map.map[0, 2])
            {
                return true;
            }
            #endregion
            return false;
        }

    }
}
