using System;
using System.Text;

namespace LambdaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Func<double, double> calculateY = x => x != 0 ? Math.Sin(x) / x : 0;

            Console.WriteLine("Введіть значення x:");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                double result = calculateY(x);
                Console.WriteLine($"y = sin({x}) / {x} = {result}");
            }
            else
            {
                Console.WriteLine("Некоректне значення!");
            }
        }
    }
}
