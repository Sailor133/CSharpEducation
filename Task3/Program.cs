internal class Program
{
    private static void Main(string[] args)
    {
        StartProgtam();
    }

    private static void StartProgtam()
    {
        Console.WriteLine("Введите что хотите сделать:");
        Console.WriteLine("1 - добавить контакт, 2 - удалить контакт, 3 - обновить контакт, 4 - вывести информацию о контакте");
        var inpute = Console.ReadLine();
        switch (inpute)
        {
            case "1":
                Console.WriteLine("Введите имя контакта");
                Console.WriteLine("Введите номер телефона контакта");

                break;
            case "2":
                Console.WriteLine("Чтобы найти контакт введите имя ИЛИ телефон контакта");
                break;
            case "3":
                Console.WriteLine("Чтобы найти контакт введите имя ИЛИ телефон контакта");
                break;
            case "4":
                Console.WriteLine("Если хотете найти определенного пользователя, введите 1, если всех -2");
                break;
        }
    }
}