using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp79
{
    class Program
    {
        static void Main(string[] args)
        {
            String Строка;
            
            for (; ; )
            {
                Строка = Microsoft.VisualBasic.Interaction.
                InputBox("Введите первое число: ", "Складываю два числа");
                if (Microsoft.VisualBasic.Information.
                    IsNumeric(Строка) == true) break;

            }

            Single X = Single.Parse(Строка);

            for (; ;  )
            {
                Строка = Microsoft.VisualBasic.Interaction.
                    InputBox("Введите второе число: ", "Складываю два числа");
                if (Microsoft.VisualBasic.Information.
                    IsNumeric(Строка) == true) break;
            }
            Single Y = Single.Parse(Строка);
            Single Z = X + Y;
            Строка = string.Format("Сумма = {0} + {1} = {2}", X, Y, Z);
            Microsoft.VisualBasic.Interaction.MsgBox(Строка);

        }
    }
}
