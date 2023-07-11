using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    /*
     * Условный оператор Switch
     */

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

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

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Сумма числел равна: " + (firstValue + secondValue));
                        break;

                    case "-":
                        Console.WriteLine("Разность числел равна: " + (firstValue - secondValue));
                        break;

                    case "*":
                        Console.WriteLine("Произведенне числел равно: " + (firstValue * secondValue));
                        break;

                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine("На ноль делить нельзя!");
                        else
                            Console.WriteLine("Частное числел равно: " + (firstValue / secondValue));
                        break;

                    default:
                        Console.WriteLine("Извините, вы выбрали не правильную опреацию..."); 
                        break;  
                }
                Console.WriteLine("Нажмите 'Enter', что бы продолжить");
                Console.ReadLine();
            }
            

        }
    }
}
