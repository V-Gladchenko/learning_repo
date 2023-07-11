using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Напишите программу,вычисляющую среднее арифметическое двух чисел
 */

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            double firstValue, secondValue;

            Console.WriteLine("Это программа, которая считает среднее арифметическое двух чисел");

            Console.WriteLine("Введите первое число: ");

            str = Console.ReadLine();

            firstValue = Convert.ToInt32(str);
            
            //firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            str = Console.ReadLine();

            secondValue = Convert.ToInt32(str);
            //secondValue = double.Parse(Console.ReadLine());

            double result = (double)(firstValue + secondValue) / 2;

            Console.WriteLine("Результат: " + result);
        }
    }
}
