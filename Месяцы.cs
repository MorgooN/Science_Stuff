using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp81
{
    class Календарь
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Использование словаря данных";
            var Месяцы = new Dictionary<String, int>();
            for (int i = 0; i <= 11; i++) Месяцы.Add(System.Globalization.CultureInfo.CurrentUICulture.DateTimeFormat.MonthNames[i], DateTime.DaysInMonth(2012, i + 1));
            Console.WriteLine("Месяцы с 30 днями: ");
            Console.WriteLine();
            foreach (KeyValuePair<String, int> Месяц in Месяцы) 
                if (Месяц.Value == 30) Console.WriteLine("{0} —{1} дней", 
                                                                Месяц.Key, Месяц.Value);
            Console.ReadKey();
        }
    }
}
