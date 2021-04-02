using System;

namespace lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня {DateTime.Now:D}");
<<<<<<< HEAD

            Console.ReadKey();
=======
>>>>>>> e59b922eb01566107280ecc34fc38b9c786969fd
        }
    }
}
