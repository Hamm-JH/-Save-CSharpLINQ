using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ_Sum();
            //LINQ_Count();
            //LINQ_Average();
            LINQ_Max();
        }

        static void LINQ_Sum()
        {
            int[] numbers = { 1, 2, 3 };

            int sum = numbers.Sum();

            Console.WriteLine($"numbers 배열 요소의 합 : {sum}");
        }

        static void LINQ_Count()
        {
            int[] numbers = { 1, 2, 3 };

            int count = numbers.Count();

            Console.WriteLine($"numbers 배열 개수 : {count}");
        }

        static void LINQ_Average()
        {
            int[] numbers = { 1, 3, 4 };

            double average = numbers.Average();

            Console.WriteLine($"numbers 배열 요소의 평균 : {average:#,###.##}");
        }

        static void LINQ_Max()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };

            int max = numbers.Max();

            Console.WriteLine($"{nameof(numbers)} 컬렉션의 최대값 : {max}");
        }
    }
}
