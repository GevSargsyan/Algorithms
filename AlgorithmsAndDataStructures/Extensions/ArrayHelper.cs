namespace AlgorithmsAndDataStructures.Extensions
{
    internal static class ArrayHelper
    {
        public static int[] GenerateIntArray(int size)
        {
            Random random = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(0, 1000);
            }
            return arr;
        }
    }
}
