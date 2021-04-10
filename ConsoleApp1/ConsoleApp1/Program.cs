using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            int action;
            while(true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t[1] Логин");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t[2] Регистрация");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t[3] Выход");
                Console.ForegroundColor = ConsoleColor.Gray;
                int.TryParse(Console.ReadLine(), out action);
            }
        }
    }
}
