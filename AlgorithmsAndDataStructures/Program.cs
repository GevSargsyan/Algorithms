using System.Diagnostics;

namespace AlgorithmsAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BinarySearch.BinarySearchMethod(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 }, 15);

            List<int> list = new List<int>();
            for (int i = 0; i < 1000000000; i++)
            {
                list.Add(i);
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            int index = list.IndexOf(100000000);//00:00:00.0401065
            BinarySearch.BinarySearchMethod(list, 100000000);// 00:00:00.0003057    (LOG2^N);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

        }
    }
}