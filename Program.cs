using System;

namespace lesson_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now:D}");

            Console.ReadKey();
        }
    }
}
