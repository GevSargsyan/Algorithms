namespace AlgorithmsAndDataStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {


            List<Player> players = new()
            {
                new Player(1000),//0
                new Player(1200),//1
                new Player(1300),//2
                new Player(1500),//3
                new Player(1500),//4
                new Player(1500),//5
                new Player(1600),//6
                new Player(1700),//7
                new Player(2000),//8
                new Player(2200) //9
            };


            var player = new Player(2500);
            int index = BinarySearch.FindFirstInsertIndex(players, player);
            players.Insert(index, player);

        }
    }
}