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

                Console.WriteLine("\t[1] Логин");
                Console.WriteLine("\t[2] Регистрация");
                Console.WriteLine("\t[3] Выход");
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
