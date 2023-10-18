using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KubrikND.Sprint2.Task1.V8.Lib;

namespace Tyuiu.KubrikND.Sprint2.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int a = 15;
            int b = 16;
            int c = 14;
            int d = 335;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            Console.Title = "Спринт #2 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант 8                                                               *");
            Console.WriteLine("* Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций а также  *");
            Console.WriteLine("*арифметических выражений, которая вернет логическую последовательность   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Результат                                                                *");
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
