using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Привет!");
        Console.WriteLine("Вайнбендер Артём Алексеевич");
        Console.WriteLine("ИСП-241");
        Console.WriteLine("01.10.2026: 14:28");

        Console.WriteLine("Меню:");
        Console.WriteLine("1 - Показать ФИО");
        Console.WriteLine("2 - Показать группу");
        Console.WriteLine("3 - Показать дату");
        Console.WriteLine("4 - Выход");
        Console.Write("Выберете: ");
        int i = Convert.ToInt32(Console.ReadLine());
        switch (i)
        {
            case 1:
                Console.WriteLine("Вайнбендер Артём Алексеевич");
                break;
            case 2:
                Console.WriteLine("ИСП-241");
                break;
            case 3:
                Console.WriteLine("01.10.2026");
                break;
            case 4:
                Console.WriteLine("До свидания!");
                return;
        }
    }
}