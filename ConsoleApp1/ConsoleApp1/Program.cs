using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int action;
            while(true)
            {
                Console.Clear();

                Console.WriteLine("[1] Логин");
                Console.WriteLine("[2] Регистрация");
                Console.WriteLine("[3] Выход");

                int.TryParse(Console.ReadLine(), out action);
            }
        }
    }
}
