namespace AlgorithmsAndDataStructures
{
    public static class BinarySearch
    {
        public static int BinarySearchMethod(List<int> array, int search)//0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 
        {
            int left = 0;
            int right = array.Count - 1;
            int middle;

            while (left <= right)
            {
                middle = (left + right) / 2;
                if (search < array[middle])
                {
                    right = middle - 1;
                }
                else if (search > array[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    return middle;
                }
            }
            return -1;
        }
    }
}
