using System;

public enum GameStatus
{
    Draw,
    Player1Wins,
    Player2Wins
}

public enum GameItem
{
    Rock,
    Paper,
    Scissors
}

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            GameItem player1Choice = (GameItem)Enum.Parse(typeof(GameItem), args[0]);
            GameItem player2Choice = (GameItem)Enum.Parse(typeof(GameItem), args[1]);
            
            GameStatus result = RockPaperScissors(player1Choice, player2Choice);
            
            switch (result)
            {
                case GameStatus.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
                case GameStatus.Player1Wins:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case GameStatus.Player2Wins:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
            if (player1 == player2)
                return GameStatus.Draw;
            if ((player1 == GameItem.Rock && player2 == GameItem.Scissors) ||
                (player1 == GameItem.Scissors && player2 == GameItem.Paper) ||
                (player1 == GameItem.Paper && player2 == GameItem.Rock))
                return GameStatus.Player1Wins;
            return GameStatus.Player2Wins;
        }
    }
}
