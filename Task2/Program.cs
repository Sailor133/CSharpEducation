namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Первые ходят крестики - X");
                Console.WriteLine("Выберете клетку для хода");
                Map.DrowMap();
                var choice = Console.ReadLine();
                int intChoice;
                try
                {
                    intChoice = int.Parse(choice);
                    Map.MakeMove(intChoice, 'X');
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
                
            }
        }


    }
}
