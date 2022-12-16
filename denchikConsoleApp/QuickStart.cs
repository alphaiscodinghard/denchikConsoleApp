using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace denchikConsoleApp
{
    internal class QuickStart
    {
        public static void Task1()
        {
            // объявление переменной
            int a;
            // присвоение
            a = 1;
            // объявление с присваиванием
            int b = -2;

            int sum = a + b; // сумма
            int prod = a * b; // произведение
            int dif = a - b; // разность
            int div = a / b; // деление
            double df = (double)a / b;

            // вывод результата
            Console.WriteLine("a + b = ");
            Console.WriteLine(sum);
            Console.Write("a * b = ");
            Console.WriteLine(prod);
            Console.Write("a - b = ");
            Console.WriteLine(dif);
            Console.Write("a / b = ");
            Console.WriteLine(div);
            Console.WriteLine(df);
        }

        public static void Task2()
        {
            Console.WriteLine("Сумма чисел a и b");
            int a;

            if (Input("a", out a) == false)
                return;

            //Console.WriteLine(a);

            int b;

            if (Input("b", out b) == false)
                return;

            //Console.WriteLine(b);

            int sum = a + b;
            string text = $"a + b = {sum}";
            Console.WriteLine(text);
        }

        public static bool Input(string name, out int a)
        {
            //string text = "Введите " + name + ": ";
            string text = $"Введите {name}: ";
            Console.Write(text);                    // приглашение к вводу
            string s = Console.ReadLine();          // чтение строки из консоли
            if (int.TryParse(s, out a) == false)    // проверка на текст
            {
                Console.WriteLine("Неккоректное значение.");
                return false;
            }

            return true;
        }
    }
}
