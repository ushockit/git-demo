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
                Console.WriteLine("\t[1] Login");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t[2] Registration");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\t[3] Exit");
                Console.ForegroundColor = ConsoleColor.Gray;
                int.TryParse(Console.ReadLine(), out action);


                switch (action)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Login in the system");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Registration in the system");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }
    }
}
