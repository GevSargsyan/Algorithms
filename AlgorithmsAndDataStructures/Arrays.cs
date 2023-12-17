namespace AlgorithmsAndDataStructures
{
    internal static class Arrays
    {
        #region FindNMaxValues

        private static int FindMax(int[] arr, int topBoundary)
        {
            int currentMax = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < topBoundary)
                {
                    currentMax = Math.Max(currentMax, arr[i]);
                    //if (arr[i] > currentMax)
                    //{
                    //    currentMax = arr[i];
                    //}
                }

            }
            return currentMax;
        }

        private static int FindMin(int[] arr, int topBoundary)
        {
            int currentMin = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > topBoundary)
                {
                    currentMin = Math.Min(currentMin, arr[i]);
                    //if (arr[i] < currentMin)
                    //{
                    //    currentMin = arr[i];
                    //}
                }

            }
            return currentMin;
        }

        public static int[] FindNMaxMinValues(int[] arr, int count, bool isMin = false)
        {
            int[] result = new int[count];
            int firstValue = isMin ? int.MinValue : int.MaxValue;
            Func<int[], int, int> func = isMin ? FindMin : FindMax;

            for (int i = 0; i < count; i++)
            {
                firstValue = func(arr, firstValue);
                result[i] = firstValue;
            }
            return result;
        }


        #endregion

    }
}
