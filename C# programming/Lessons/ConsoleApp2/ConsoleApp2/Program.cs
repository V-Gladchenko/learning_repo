using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
/*
 * конвертация строки 
 * класс Convert
 */

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str; 

            int a, b;

            Console.WriteLine("Enter the number 1: "); // Запрос числа на ввод пользователем

            str = Console.ReadLine(); // Считывание данных типа "string" с помощью метода .ReadLine

            a = Convert.ToInt32(str); // Конвертирование строки в число и присваивание переменной а

            Console.WriteLine("Enter the number 2: "); 

            str = Console.ReadLine();

            b = Convert.ToInt32(str);

            int result = a + b; // Переменная типа int которая считает сумму двух чисел 

            Console.WriteLine("Сумма чисел = " + result); // Вывод в консоль строки с результатом (Число типа int снова конвертируеться в string при использовании метода WriteLine )

            string str2 = "1.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
            double c = Convert.ToDouble(str2, numberFormatInfo);
            Console.WriteLine(c);

        }
    }
}
