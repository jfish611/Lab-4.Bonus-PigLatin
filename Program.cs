using System;

namespace Lab4Bonus_PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.WriteLine("\nEnter a word or words to translate to Pig Latin.");


                //string userInput = Console.ReadLine().ToLower();
                string userInput = Console.ReadLine();
                string[] splitWord = userInput.Split(" ");
                string snip;
                string restOf;

                foreach (string userWord in splitWord)
                {
                    for (int i = 0; i < userWord.Length - 1; i++)
                    {
                        if (userWord[0] == 'a' || userWord[0] == 'e' || userWord[0] == 'i' || userWord[0] == 'o' || userWord[0] == 'u' || userWord[0] == 'A' || userWord[0] == 'E' || userWord[0] == 'I' || userWord[0] == 'O' || userWord[0] == 'U')
                        {
                            Console.Write(userWord + "way ");
                            break;
                        }
                        else if (userWord[i] == 'a' || userWord[i] == 'e' || userWord[i] == 'i' || userWord[i] == 'o' || userWord[i] == 'u' || userWord[i] == 'A' || userWord[i] == 'E' || userWord[i] == 'I' || userWord[i] == 'O' || userWord[i] == 'U')
                        {
                            snip = userWord.Substring(0, i);
                            restOf = userWord.Substring(i, userWord.Length - i);
                            Console.Write($"{restOf}{snip}ay ");
                            break;
                        }
                    }
                }
                bool valid = false;
                while (valid != true)
                {
                    Console.WriteLine("\nKeep Going?");
                    string keepGoingAns = Console.ReadLine().ToLower();

                    if (keepGoingAns == "y")
                    {
                        valid = true;
                        keepGoing = true;
                    }
                    else if (keepGoingAns == "n")
                    {
                        valid = true;
                        keepGoing = false;
                        Console.WriteLine("Byeeee");
                    }
                    else
                    {
                        valid = false;
                    }
                }
            }
        }
    }
}
