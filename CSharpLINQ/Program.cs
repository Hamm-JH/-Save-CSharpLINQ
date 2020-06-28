using System;
using System.Linq;

namespace CSharpLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            LINQ_Sum();
        }

        static void LINQ_Sum()
        {
            int[] numbers = { 1, 2, 3 };

            int sum = numbers.Sum();

            Console.WriteLine($"numbers 배열 요소의 합 : {sum}");
        }
    }
}
