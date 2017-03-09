namespace Kata3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var players = new Player[5] {
                new Player("David", "Bowie", 1),
                new Player("Mark", "Braxton", 5),
                new Player("Sally", "Forth", 2),
                new Player("Janet", "Jones", 7),
                new Player("Dennis", "Peterson", 3)
            };
            var leaderboard = new Leaderboard();
            leaderboard.AddPlayers(players);
            leaderboard.PrintStats();
        }
    }
}
