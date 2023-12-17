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

        #region Distinct
        public static long[] DistinctArray(long[] arr)
        {
            List<long> longs = new List<long>();
            bool alreadyExists;
            for (int i = 0; i < arr.Length; i++)
            {
                alreadyExists = false;
                for (int j = 0; j < longs.Count; j++)
                {
                    if (longs[j] == arr[i])
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    longs.Add(arr[i]);
                }
            }
            return longs.ToArray();
        }

        public static int[] DistinctSorted(int[] arr)
        {
            int previousNum = arr[0];
            List<int> ints = new List<int>();
            ints.Add(previousNum);
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != previousNum)
                {
                    previousNum = arr[i];
                    ints.Add(previousNum);
                }
            }
            return ints.ToArray();
        }

        #endregion
    }
}
