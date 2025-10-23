using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int result1 = calc.AddNumbers(5, 3);

            Console.WriteLine($"AddNumbers result: {result1}");
        }
    }
}
