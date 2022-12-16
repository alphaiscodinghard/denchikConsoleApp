//Переписанный метод ввода, работает лучше чем то что давал Волков.
//Использование - Tools.ToDouble("имя", out переменная)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denchikConsoleApp
{
    internal class Tools
    {
        public static double ToDouble(string name, out double value)
        {
            Console.Write($"Введите {name}: ");
            string str = Console.ReadLine();
            while (double.TryParse(str, out value) == false)
            {
                Console.WriteLine("Неккоректное значение.");
                Console.Write($"Введите {name}: ");
                str = Console.ReadLine();
            }
            return value;
        }
    }
}
