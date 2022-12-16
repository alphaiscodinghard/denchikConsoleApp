using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace denchikConsoleApp //поменяй!!
{
    internal class QuickStart
    {
        public static void Task1()
        {
            Console.WriteLine("Задача №1: Даны числа A и B, найти их сумму, разность и произведение");
            if (!(Input("a", out double a))) {  }
            if (!(Input("b", out double b))) {  }
            double sum = a + b; // сумма
            double prod = a * b; // произведение
            double dif = a - b; // разность
            double df = (double)a / b; // деление

            // вывод результата
            Console.WriteLine("a + b = ");
            Console.WriteLine(sum);
            Console.Write("a * b = ");
            Console.WriteLine(prod);
            Console.Write("a - b = ");
            Console.WriteLine(dif);
            Console.Write("a / b = ");
            Console.WriteLine(df);
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task2()
        {
            Console.WriteLine("Задача №2: Даны числа A и B, найти их сумму");
            Console.WriteLine("Сумма чисел a и b");

            if (Input("a", out double a) == false)
                return;

            //Console.WriteLine(a);


            if (Input("b", out double b) == false)
                return;

            //Console.WriteLine(b);

            double sum = a + b;
            string text = $"a + b = {sum}";
            Console.WriteLine(text);
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task3()
        {
            Console.WriteLine("Задача №3: Дано ребро куба, найти площадь его поверхности и его объем");
            if (!(Input("a", out double a))) { return; }
            double v = a * a * a;
            double s = a * a;
            Console.WriteLine($"v = {v}; s = {s}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task4()
        {
            Console.WriteLine("Задача №4: Даны 2 действительных числа. Найти среднее арифметическое и среднее геометрическое их модулей");
            if (!(Input("a", out double a))) { return; }
            if (!(Input("b", out double b))) { return; }
            double arif = (Math.Abs(a) + Math.Abs(b)) / 2;
            double geom = Math.Sqrt(Math.Abs(a) * Math.Abs(b));
            Console.WriteLine($"Cреднее геометрическое: {arif}");
            Console.WriteLine($"Cреднее геометрическое: {geom}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task5()
        {
            Console.WriteLine("Задача №5: Даны два действительных числа X и Y, вычислить |x|-|y|/1+|xy|");
            if (!(Input("x", out double x))) { return; }
            if (!(Input("y", out double y))) { return; }
            double answer = (Math.Abs(x) + Math.Abs(y)) / (1 + Math.Abs(x * y));
            Console.WriteLine($"Ответ: {answer}");

            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Task6()
        {
            Console.WriteLine("Задача №6: Дано число a, не пользуясь ничем кроме умножения получить а в 4 степени за 2 операции");
            if (!(Input("a", out double a))) { return; }
            a = a * a;
            a = a * a;
            Console.WriteLine($"Ответ: {a}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }
        public static void Task7()
        {
            Console.WriteLine("Задача №7: Дано число a, не пользуясь ничем кроме умножения получить а в 6 степени за 3 операции");
            if (!(Input("a", out double a))) { return; }
            a = a * a;
            a = a * a * a;
            Console.WriteLine($"Ответ: {a}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }



        public static bool Input(string name, out double a)
        {
            //string text = "Введите " + name + ": ";
            string text = $"Введите {name}: ";
            Console.Write(text);                    // приглашение к вводу
            string s = Console.ReadLine();          // чтение строки из консоли
            if (double.TryParse(s, out a) == false)    // проверка на текст
            {
                Console.WriteLine("Неккоректное значение.");
                return false;
            }

            return true;
        }
    }
}
