using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_13
    /*
     * Напишите программу, проверяющую чсило, введенное с клавиатуры на четность.
     */
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourValue;

            Console.WriteLine("Эта программа проверят число на чётность. Ведите ваше число");

            yourValue = int.Parse(Console.ReadLine());

            if (yourValue % 2 == 0)
            {
                Console.WriteLine("Число " + yourValue + " чётное");
            }
            else
            {
                Console.WriteLine("Число " + yourValue + " нечётное");
            }

        }
    }
}
