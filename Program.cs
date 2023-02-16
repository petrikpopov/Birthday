using System;

namespace StuctBirthday16._02._2023LB
{
    class P
    {
        static void Main(string []arr)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            DateTime obj = new DateTime(2003, 3, 7);//год,месяц,день
            DateTime obj1 = new DateTime(2003, 3, 20);//год,месяц,день
            DateTime obj2 = new DateTime(2025, 3, 7);
            Console.Write("День рождение человека:\t");
            Console.WriteLine(obj);
            Console.WriteLine("\n");
            Console.Write("Количесвто дней до дня рождения человека:\t");
            Console.WriteLine(obj1.Subtract(obj));
            Console.WriteLine("\n");
            Console.Write("День недели когда родился человек:\t");
            Console.WriteLine(obj.DayOfWeek);
            Console.WriteLine("\n");
            Console.Write("День недели когда родился человек в 2025 году:\t");
            Console.WriteLine(obj2.DayOfWeek);
            Console.WriteLine("\n");
        }

    }
   
}
