using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp19
{
    class Program
    {
        static double f(double x)
        {
            return Math.Exp(-x) - Math.Sin(x);  // функция возвращает ... функцию    
        }
        static double df(double x)
        {
            return -Math.Exp(-x) - Math.Cos(x);     // функция возвращает производную
        }
        static double approx(double x)                 // приближение Ньютона
        {
            return x - f(x) / df(x);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please,Enter a starting value");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter error of calculation");
            double eps = Convert.ToDouble(Console.ReadLine()); //остаточный член(крайне малая величина)
            for (double iteration = 1; eps < Math.Abs(f(x)); ++iteration)
            {
                System.Console.Clear();    // очистка консоли
                Console.WriteLine($"iteration:  {iteration}");
                if (df(x) == 0)  // если производная = 0, то выполение прекращается т.к будет деление на ноль
                    break;
                Console.WriteLine($"x =  {x}");
                Console.WriteLine($"Approximation =  {approx(x)}");
                Console.WriteLine($"df(x):  {df(x)}");
                Console.WriteLine($"f(x) : { f(x)}");
                x = approx(x);
            }
            Console.ReadKey();
        }
    }
}


