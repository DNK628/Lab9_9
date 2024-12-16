using System;
using System.Text;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Func<double, double> positiveFunc = x => Math.Sin(2 * x); 
            Func<double, double> nonPositiveFunc = x => 1 + 2 * Math.Sin(2 * x); 

            Console.WriteLine("Введіть значення x:");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                double result = x > 0 ? positiveFunc(x) : nonPositiveFunc(x);
                Console.WriteLine($"F({x}) = {result}");
            }
            else
            {
                Console.WriteLine("Некоректне значення!");
            }
        }
    }
}
