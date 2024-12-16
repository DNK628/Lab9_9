using System;
using System.Text;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Predicate<double> isNegative = x => x < 0;

            Console.WriteLine("Введіть число:");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                bool result = isNegative(x);
                Console.WriteLine($"Число {x} є від'ємним: {result}");
            }
            else
            {
                Console.WriteLine("Некоректне значення!");
            }
        }
    }
}

