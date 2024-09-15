using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double firstvalue, secondvalue, result;


                try
                {
                    Console.WriteLine("Введите первое число:");
                    firstvalue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число:");
                    secondvalue = double.Parse(Console.ReadLine());
                    result = firstvalue / secondvalue;
                    Console.WriteLine("Результат:" + result);

                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка! Введите число");
                }




                Console.ReadLine();


            }
        }
    }
}
