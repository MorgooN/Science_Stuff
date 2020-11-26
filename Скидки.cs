using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Интервалы
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Программирование интервалов";
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Введите сумму за купленные товары: ");
            Single Сумма, Скидка;
            for (; ;  )
            {
                var Строка = Console.ReadLine();
                Сумма = Single.Parse(Строка);
                if(0<Сумма && Сумма <=10)
                {
                    Скидка = 10;
                }
                else if(10 < Сумма && Сумма <=20)
                {
                    Скидка = 20;
                }
                else if (Сумма >20)
                {
                    Скидка = 30;
                }
                else
                {
                    Console.WriteLine("Сумма = {0} , поэтому - завершение программы", Сумма);
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Сумма = {0}, поэтому скидка = {1}%", Сумма, Скидка);
            }  while (true) ; 
        }
    }
}
