using System;

namespace ConsoleApp72
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Title = "Tablica"; Console.Clear();
            Console.WriteLine("Число Корень");
            for(Double i = 0; i<=10;++i)
            {
                Console.WriteLine("{0,4} {1,8:F4}", i, Math.Sqrt(i));
            }
            Console.ReadKey();

        }
    }
}
