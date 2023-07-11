using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3
{
    /*
     * Напишите простой конвертер валют
     * (без возможности динамического выбора валюты пользователем )
     * Валюты заданы хардкодом и не изменяются. Тип валют на выбор программиста.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double UsdtoUah = 36.78;
            double EurtoUah = 40.55;
            double UsdtoEur = 0.91;
            double USD;
            double EUR;

            Console.WriteLine("Введите сумму в USD: ");

            USD = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сумму в EUR: ");

            EUR = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD в UAH =  " + USD * UsdtoUah);

            Console.WriteLine(EUR + " EUR в UAH =  " + EUR * EurtoUah);

            Console.WriteLine(USD + " USD в EUR =  " + USD * UsdtoEur);




        }
    }
}
