using AlgorithmsAndDataStructures.Extensions;

namespace AlgorithmsAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var a = Arrays.FindNMaxMinValues(new int[] { 1, 23, 4, 5, 6, 7, 8 }, 3);
            Console.WriteLine(a.ToArrayString());
        }
    }
}