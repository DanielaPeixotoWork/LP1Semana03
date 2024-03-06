using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {

        if (args.Length != 1)
        {
            Console.WriteLine("Insira um parametro:");
            return;
        }

        string perksString = args[0];
        string[] validPerks = { "w", "a", "s", "d" };
        Dictionary<string, bool> playerPerks = new Dictionary<string, bool>
        {
            { "WaterBreathing", false },
            { "Stealth", false },
            { "DoubleJump", false },
            { "AutoHeal", false }
        };

        foreach (char perkChar in perksString)
        {
            string perk = perkChar.ToString().ToLower();

            // Verifica se é uma perk válida
            if (!validPerks.Contains(perk))
            {
                Console.WriteLine("Unknown perk!");
                return;
            }
        }

        }
    }
}