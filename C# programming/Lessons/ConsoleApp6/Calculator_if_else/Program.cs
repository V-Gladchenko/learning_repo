using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_if_else
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double firstValue, secondValue;
                string operation;

                try
                {
                    Console.WriteLine("Введите первое число: ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Не удалось преобразовать строку в число!");
                    Console.WriteLine("Нажмите 'Enter', что бы продолжить");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Выбирите операцию: ");
                Console.WriteLine("  +");
                Console.WriteLine("  -");
                Console.WriteLine("  *");
                Console.WriteLine("  /");

                operation = Console.ReadLine();

                if (operation == "+")
                {
                    Console.WriteLine("Сумма числел равна: " + (firstValue + secondValue));
                }
                else if (operation == "-")
                {
                    Console.WriteLine("Сумма числел равна: " + (firstValue - secondValue));
                }
                else if (operation == "*")
                {
                    Console.WriteLine("Сумма числел равна: " + (firstValue * secondValue));
                }
                else if (operation == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine("На ноль делить нельзя!");
                    else
                        Console.WriteLine("Частное числел равно: " + (firstValue / secondValue));
                }
                else
                {
                    Console.WriteLine("Извините, вы выбрали не правильную опреацию...");
                }
                Console.WriteLine("Нажмите 'Enter', что бы продолжить");
                Console.ReadLine();
            }
            
        }
    }
}
