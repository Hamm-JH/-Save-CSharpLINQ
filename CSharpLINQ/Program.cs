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
            //LINQ_OrderByDescending();

            //LINQ_MethodChain();

            //LINQ_UseCase();

            //LINQ_SingleOrDefault();
            //LINQ_FirstOrDefault();

            LINQ_QuerySyntax();
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

        #region Method chaining

        static void LINQ_MethodChain()
        {
            List<string> names = new List<string> { ".NET", "C#", "TypeScript" };

            var results = names.Where(name => name.Length > 2).OrderBy(n => n);

            foreach(var name in results)
            {
                Console.WriteLine(name);
            }
        }

        #endregion Method chaining

        #region Simple LINQ use case

        static void LINQ_UseCase()
        {
            var numbers = Enumerable.Range(11, 10);

            foreach(var num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine();

            foreach(var num in numbers.Where(n => n % 2 == 0).OrderByDescending(n => n))
            {
                Console.Write($"{num} ");
            }
        }

        #endregion Simple LINQ use case

        #region Single, SingleOrDefault

        static void LINQ_SingleOrDefault()
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue" };
            
            string red = colors.Single(c => c == "Red");
            Console.WriteLine(red);

            // 없는 데이터를 요청하면 에러 발생
            //string black = colors.Single(color => color == "Black");
            //Console.WriteLine(black);

            string black = colors.SingleOrDefault(color => color == "Black");
            Console.WriteLine(black);
        }

        #endregion Single, SingleOrDefault

        #region First, FirstOrDefault

        static void LINQ_FirstOrDefault()
        {
            List<string> colors = new List<string> { "Red", "Green", "Blue" };

            Console.WriteLine(colors.First(c => c == "Red"));

            // 에러 발생
            //Console.WriteLine(colors.First(c => c == "Black"));

            Console.WriteLine(colors.FirstOrDefault(c => c == "Black"));
        }

        #endregion First, FirstOrDefault

        #region Query syntax

        static void LINQ_QuerySyntax()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            var evenNumbers =
                from num in arr
                where num % 2 == 0
                select num;

            foreach(var number in evenNumbers)
            {
                Console.WriteLine($"짝수 : {number}");
            }
        }

        #endregion Query syntax
    }
}
