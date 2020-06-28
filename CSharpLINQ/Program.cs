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

            //LINQ_Max();
            //LINQ_Min();

            //LINQ_Where();
            //LINQ_ConvertToList();
            //LINQ_CheckCondition();
            //LINQ_CheckCondition2();
            //LINQ_CheckCondition3();
            //LINQ_CheckCondition4();

            //LINQ_All();
            //LINQ_Any();

            //LINQ_Take();
            //LINQ_Skip();

            //LINQ_Distinct();

            //LINQ_OrderBy();
            LINQ_OrderByDescending();
        }

        #region Sum

        static void LINQ_Sum()
        {
            int[] numbers = { 1, 2, 3 };

            int sum = numbers.Sum();

            Console.WriteLine($"numbers 배열 요소의 합 : {sum}");
        }

        #endregion Sum

        #region Count

        static void LINQ_Count()
        {
            int[] numbers = { 1, 2, 3 };

            int count = numbers.Count();

            Console.WriteLine($"numbers 배열 개수 : {count}");
        }

        #endregion Count

        #region Average

        static void LINQ_Average()
        {
            int[] numbers = { 1, 3, 4 };

            double average = numbers.Average();

            Console.WriteLine($"numbers 배열 요소의 평균 : {average:#,###.##}");
        }

        #endregion Average

        #region Max, Min

        static void LINQ_Max()
        {
            List<int> numbers = new List<int>() { 1, 2, 3 };

            int max = numbers.Max();

            Console.WriteLine($"{nameof(numbers)} 컬렉션의 최대값 : {max}");
        }

        static void LINQ_Min()
        {
            List<double> numbers = new List<double>() { 3.3, 2.2, 1.1 };

            double min = numbers.Min();

            Console.WriteLine($"{nameof(numbers)} 리스트의 최소값 : {min:.00}");
        }

        #endregion Max, Min

        #region Where, CheckCondition

        static void LINQ_Where()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            IEnumerable<int> newNumbers = numbers.Where(number => number > 3);

            foreach(var n in newNumbers)
            {
                Console.WriteLine(n);
            }
        }

        static void LINQ_ConvertToList()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            List<int> newNumbers = numbers.Where(number => number > 3).ToList();

            foreach(var number in newNumbers)
            {
                Console.WriteLine(number);
            }
        }

        static void LINQ_CheckCondition()
        {
            List<int> numbers = new List<int> { 1, 2, 3 };

            int number = numbers.Where(n => n % 2 == 1).Sum();

            Console.WriteLine(number);
        }

        static void LINQ_CheckCondition2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            // 배열에서 홀수만 추출 : 람다 식 사용
            var query = arr.Where(num => num % 2 == 1);

            foreach (var n in query)
            {
                Console.WriteLine(n);
            }
        }

        static void LINQ_CheckCondition3()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            var nums = numbers.Where(it => it % 2 == 0 && it > 3);  // 짝수 && 3보다 큰 수

            foreach(var num in nums)
            {
                Console.WriteLine(num);
            }
        }

        static void LINQ_CheckCondition4()
        {
            bool[] blns = { true, false, true, false, true };

            Console.WriteLine(blns.Count());
            Console.WriteLine(blns.Count(bln => bln == true));
            Console.WriteLine(blns.Count(bln => bln == false));
        }

        #endregion Where, CheckCondition

        #region All, Any

        static void LINQ_All()
        {
            bool[] completes = { true, true, true };
            Console.WriteLine(completes.All(c => c == true));

            bool[] inCompletes = { true, false, true };
            Console.WriteLine(inCompletes.All(c => c == true));
        }

        static void LINQ_Any()
        {
            bool[] completes = { true, true, true };
            Console.WriteLine(completes.Any(c => c == false));

            bool[] inCompletes = { true, false, true };
            Console.WriteLine(inCompletes.Any(c => c == false));
        }

        #endregion All, Any

        #region Take, Skip

        static void LINQ_Take()
        {
            var data = Enumerable.Range(0, 99);

            foreach(int num in data.Take(5))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            foreach(int num in data.Where(n => n % 2 == 0).Take(5))
            {
                Console.WriteLine(num);
            }
        }

        static void LINQ_Skip()
        {
            var data = Enumerable.Range(0, 100);

            foreach(int num in data.Skip(10).Take(5))
            {
                Console.WriteLine(num);
            }
        }

        #endregion Take, Skip

        #region Distinct, Repeat

        static void LINQ_Distinct()
        {
            var data = Enumerable.Repeat(3, 5); // 3을 5개 저장

            foreach(int num in data.Distinct())     // Distinct로 중복 제거
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            int[] arr = { 2, 2, 3, 3, 3 };      // 2와 3을 중복해서 배열에 저장

            foreach (int num in arr.Distinct())
            {
                Console.WriteLine(num);
            }
        }

        #endregion Distinct, Repeat

        #region OrderBy, OrderByDescending

        static void LINQ_OrderBy()
        {
            string[] colors = { "Red", "Green", "Blue" };
            IEnumerable<string> sortedColors = colors.OrderBy(name => name);

            foreach(var color in sortedColors)
            {
                Console.WriteLine(color);
            }
        }

        static void LINQ_OrderByDescending()
        {
            List<string> colors = new List<string> { "Red", "Blue", "Green" };
            var sortedColors = colors.OrderByDescending(c => c);

            foreach (var color in sortedColors)
            {
                Console.WriteLine(color);
            }
        }

        #endregion OrderBy, OrderByDescending
    }
}
