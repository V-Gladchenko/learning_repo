using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 5;

            int result = a + b;
            Console.WriteLine(result);
            int result2 = a - b;
            Console.WriteLine(result2);
            int result3 = a * b;
            Console.WriteLine(result3);
            double result4 = (double) a / b;
            Console.WriteLine(result4);
            int c = 10;
            int d = 3;
            int result5 = c % d;
            Console.WriteLine(result5);


        }
    }
}
