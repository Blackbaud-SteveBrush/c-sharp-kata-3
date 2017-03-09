using System;

namespace Kata3
{
  public class Leaderboard
  {
    private Player[] _players;

    public void AddPlayers(Player[] players) 
    {
      _players = players;
    }

    private Player[] SortPlayers(Player[] players) 
    {
      Array.Sort(players);
      return players;
    }

    public void PrintStats()
    {
      var sortedPlayers = SortPlayers(_players);
      var winner = sortedPlayers[0];
      var loser = sortedPlayers[sortedPlayers.Length - 1];

      Console.WriteLine("Leaderboard:");
      for (var i = 0; i < sortedPlayers.Length; i++)
      {
        Console.WriteLine(sortedPlayers[i].GetDetails());
      }
      
      Console.WriteLine($"Congrats to {winner.FullName} for the win!");
      Console.WriteLine($"{loser.FullName}, you're a real American loser... :(");
    }
  }
}
