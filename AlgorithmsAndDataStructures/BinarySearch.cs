namespace AlgorithmsAndDataStructures
{

    public class Player
    {
        public Player(int point)
        {
            Iteration++;
            Point = point;
            Name = "A" + Iteration.ToString();
        }
        public static int Iteration { get; set; }
        public int Point { get; set; }
        public string Name { get; set; }
    }

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

        public static int FindFirstInsertIndex(List<Player> players, Player player)
        {

            int left = 0;
            int right = players.Count - 1;
            int middle;

            while (left < right)
            {
                middle = (left + right) / 2;
                if (player.Point <= players[middle].Point)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }

            }
            if (right == players.Count - 1 && player.Point > players[right].Point)
            {
                right++;
            }
            return right;
        }


    }
}
