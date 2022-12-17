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
            Console.Write("a + b = ");
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
            a *= a;
            a *= a;
            Console.WriteLine($"Ответ: {a}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task7()
        {
            Console.WriteLine("Задача №7: Дано число a, не пользуясь ничем кроме умножения получить а в 6 степени за 3 операции");
            if (!(Input("a", out double a))) { return; }
            a *= a;
            a = a * a * a;
            Console.WriteLine($"Ответ: {a}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task8()
        {
            Console.WriteLine("Задача №8: Дана высота h, определить время падения камня на поверхность Земли с этой высоты");
            if (!(Input("h", out double h))) { return; }
            double t = Math.Sqrt(2 * h / 2);
            Console.WriteLine($"Время равно {t}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task9()
        {
            Console.WriteLine("Задача №9: Дана равнобедренная трапеция, у которой основания A и B, известен угол C при большем основании A. Найти площадь.");
            if (!(Input("длинну большего основания", out double a))) { return; }
            if (!(Input("длинну меньшего основания", out double b))) { return; }
            if (!(Input("c", out double c))) { return; }
            double d = (a - b) / 2;
            double h = Math.Tan((c * Math.PI) / 180) * d;
            double s = (a + b) / 2 * h;
            Console.WriteLine($"Ответ: {s}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task10()
        {
            if (!Input("x", out double x)) { return; }
            if (!Input("y", out double y)) { return; }
            double s = x * x + 4; 
            double d = Math.Exp(-2*Math.Log(Math.Exp(-x)));
            double b = (1 + y) * s * ((x + y) / d);
            Console.WriteLine($"Ответ: {b}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }
        
        public static void Task11()
        {
            Console.WriteLine("Задача №11: Даны 2 числа A и B, найти наименьшее и наибольшее число");
            if (!(Input("a", out double a))) { return; }
            if (!(Input("b", out double b))) { return; }
            double min, max;
            if (a<b) { min = a; max = b; }
            else { min = b; max = a; }
            Console.WriteLine($"Наименьшее число: {min}");
            Console.WriteLine($"Наибольшее число: {max}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }
        
        public static void Task12()
        {
            Console.WriteLine("Задача №12: Даны 3 числа A и B и C, найти наименьшее и наибольшее число");
            if (!(Input("a", out double a))) { return; }
            if (!(Input("b", out double b))) { return; }
            if (!(Input("c", out double c))) { return; }
            double min, max;
            if (a < c)
            {
                if (a < b) { min = a; }
                else { min = b; }
            }
            else
            {
                if (c < b) { min = c; }
                else { min = b; }
            }
            if (a > c)
            {
                if (a > b) { max = a; }
                else { max = b; }
            }
            else
            {
                if (c > b) { max = c; }
                else { max = b; }
            }
            Console.WriteLine($"Наименьшее число: {min}");
            Console.WriteLine($"Наибольшее число: {max}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task13()
        {
            Console.WriteLine("Задача №13: Используя лишь +, -, * вычислить 2a^4-3a^3+4a^2-5a+6 за 4 операции каждого типа");
            if (!(Input("a", out double a))) { return; }
            double b = (((2 * a - 3) * a + 4) * a - 5) * a + 6;
            Console.WriteLine($"Ответ: {b}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }
        
        public static void Task14()
        {
            Console.WriteLine("Задача №14: Даны значения X и Y, надо вычислить выражение.");
            if (!(Input("x", out double x))) { return; }
            if (!(Input("y", out double y))) { return; }
            double a = 1 + Math.Abs(y + x) + ((y - x) * (y - x) / 2) + (Math.Abs(y - x) * Math.Abs(y - x) * Math.Abs(y - x)) / 3;
            Console.WriteLine($"Ответ: {a}");
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task15()
        {
            Console.WriteLine("Задача №15: Даны числа a,b,c. Проверить, выполняется ли a < b < c.");
            if (!(Input("a", out double a))) { return; }
            if (!(Input("b", out double b))) { return; }
            if (!(Input("c", out double c))) { return; }
            if ( a < b & b < c )
            {
                Console.WriteLine("Выпоняется");
            }
            else
            {
                Console.WriteLine("Не выполняется");
            }
            Console.Write("Нажмите enter, чтобы перейти к следующей задаче...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Task16()
        {
            Console.WriteLine("Задача №16: Даны числа a,b. Если a > b, то вывести a. Если нет, то вывести и a, и b.");
            if (!(Input("a", out double a))) { return; }
            if (!(Input("b", out double b))) { return; }
            if (a > b)
            {
                Console.WriteLine($"Ответ: {a}");
            }
            else
            {
                Console.WriteLine($"Ответ: {a}, {b}");
            }
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
