using System.Diagnostics;
using Xunit.Sdk;

namespace UnitTests
{
    public class Functional
    {
        public static IEnumerable<int> Nums 
            => Enumerable.Range(-10000, 20001)
            .Reverse()
            .ToList();

        public readonly static Action<string, object> Print = (message, input)
                => Console.WriteLine($"{message} => {input}");

        public readonly static Func<int, int> Triple = x => x * 3;
        public readonly static Func<int, bool> IsOdd = x => x % 2 == 0;
        public readonly static Func<IEnumerable<int>, IEnumerable<int>> Sort = x => x.OrderBy(x => x);
        public readonly static Func<IEnumerable<int>, IEnumerable<int>> Filter = (nums) => nums.Where(IsOdd);              

        public static void Run_Triples()
        {
            var range = Enumerable.Range(1, 3);

            Print("triples", string.Join(" ", range.Select(Triple).ToList()));            
        }        

        public static void Run_Odd()
        {
            int[] original = { 7, 6, 1, 2 };

            var sorted = Sort(original);
            var filtered = Filter(original);
            
            Print("Sorted", string.Join(" ", sorted));
            Print("Filtered", string.Join(" ", filtered));
            Print("Original", string.Join(" ", original));
        }   

        public static void Run_Sum()
        {
            var stopWatch = Stopwatch.StartNew();

            stopWatch.Start();                            

            var task1 = () => Print("task1", Nums.Sum());
            var task2 = () =>
            {
                var nums2 = Sort(Nums);

                Print("task2", nums2.Sum());
            };

            Parallel.Invoke(task1, task2);

            stopWatch.Stop();
            Print("Elapsed", stopWatch.Elapsed.TotalSeconds.ToString());
        }
    }
}
