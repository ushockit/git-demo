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

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t[1] Login");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t[2] Registration");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t[3] Exit");
                Console.ForegroundColor = ConsoleColor.Gray;
                int.TryParse(Console.ReadLine(), out action);


                Menu(action);
            }
        }

        static void Menu(int action)
        {
            switch (action)
            {
                case 1:
                    Console.WriteLine("Авторизация в системе");
                    break;
                case 2:
                    Console.WriteLine("Регистрация в системе");
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
