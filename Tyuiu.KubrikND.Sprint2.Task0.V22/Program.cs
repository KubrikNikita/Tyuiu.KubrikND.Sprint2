﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KubrikND.Sprint2.Task0.V22.Lib;

namespace Tyuiu.KubrikND.Sprint2.Task0.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int x = 3105;
            int y = 77;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            Console.Title = "Спринт #2 | Выполнил: Кубрик Н.Д.| ИСПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант 22                                                               *");
            Console.WriteLine("* Выполнил: Кубрик Н.Д.| ИСПБ-23-1                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и арифметических выражений,    *");
            Console.WriteLine("*которая вернет логическую последовательность(массив)                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
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