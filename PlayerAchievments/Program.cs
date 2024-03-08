using System;

enum Achievement
{
    DefeatOptionalBoss,
    FindHiddenLevel,
    FinishGame
}

class Program
{
    static void Main(string[] args)
    {
        Achievement[][] playerAchievements = new Achievement[numPlayers][];

        for (int i = 0; i < numPlayers; i++)
        {
            Console.WriteLine($"Jogador {i + 1}:");
            playerAchievements[i] = new Achievement[3];
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Insira o achievement {j + 1} para o jogador {i + 1} (ou 'exit' para terminar): ");
                string achievementInput = Console.ReadLine().Trim().ToLower();
                if (achievementInput == "exit")
                {
                    break;
                }
                else if (achievementInput == "Defeat Optional Boss")
                {
                    playerAchievements[i][j] = Achievement.DefeatOptionalBoss;
                }
                else if (achievementInput == "Find Hidden Level")
                {
                    playerAchievements[i][j] = Achievement.FindHiddenLevel;
                }
                else if (achievementInput == "Finish Game")
                {
                    playerAchievements[i][j] = Achievement.FinishGame;
                }
                else
                {
                    Console.WriteLine("Achievement não existente. Insira um dos seguintes: 'Defeat Optional Boss', 'Find Hidden Level', 'Finish Game'.");
                    j--;
                }
            }
        }

        for (int i = 0; i < numPlayers; i++)
        {
            Console.WriteLine($"Achievements do jogador {i + 1}:");
            for (int j = 0; j < playerAchievements[i].Length; j++)
            {
                if (playerAchievements[i][j] != 0)
                {
                    Console.WriteLine($"- {playerAchievements[i][j]}");
                }
            }

            if (playerAchievements[i].Length == 3)
            {
                Console.WriteLine("Completionist!");
            }
        }
    }
}