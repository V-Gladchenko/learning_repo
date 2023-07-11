using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2
{
    /*
     * Введите три числа и выведите на экран занчение суммы и произведения этих чисел.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue, thirdValue;

            Console.WriteLine("Это программа, которая считает сумму и произведение трёх чисел.");

            Console.WriteLine("Введите первое число: ");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите теретье число: ");

            thirdValue = double.Parse(Console.ReadLine());

            double sum = firstValue + secondValue + thirdValue;

            Console.WriteLine("Сумма трёх чисел: " + sum);

            double product = firstValue * secondValue * thirdValue;

            Console.WriteLine("Произведение трёх чисел: " + product);
        }
    }
}
