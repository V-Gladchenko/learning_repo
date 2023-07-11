using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Операторы отношений
 * Операции сравнения 
 */

/*
 *                  == Равно
 *                  != Не равно
 *                  > Больше
 *                  < Меньше
 *                  >= Больше или Равно
 *                  <= Меньше или Равно 
 */

namespace Lesson_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            
            int b = 9;


            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

        }
    }
}
