using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("Digite uma frase:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Digite um caractere:");
        char charToReplace = Console.ReadKey().KeyChar;
        Console.WriteLine();

        string charAsString = char.ToString(charToReplace);


        string resultString = inputString.Replace(charAsString, "X");


        Console.WriteLine("A frase ficaria: " + resultString);
        }
    }
}
