using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();

                

                double firstValue, secondValue;
                string Action;



                Console.WriteLine("Введите первое число:");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                secondValue= double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                Action = Console.ReadLine();

                if (Action == "+")

                {
                    Console.WriteLine(firstValue + secondValue);
                }

                else if ( Action == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }

                else if ( Action == "*")
                {
                    Console.WriteLine(firstValue * secondValue);
                }

                else if ( Action == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstValue / secondValue);

                }

                else
                {
                    Console.WriteLine("Ошибка! Неизвестное действие");
                }



                Console.ReadLine();

            }
        }
    }
}
