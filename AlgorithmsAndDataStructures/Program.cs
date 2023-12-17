using AlgorithmsAndDataStructures.Extensions;

namespace AlgorithmsAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] phoneNumbers = new long[] { +374123456L, +374001234L, +374123456L, +374374374L, +374001234L };
            Console.WriteLine(Arrays.DistinctArray(phoneNumbers).ToArrayString());

            int[] numbers = new int[] { 1, 2, 2, 3, 4, 4, 5 };
            Console.WriteLine(Arrays.DistinctSorted(numbers).ToArrayString());
        }
    }
}