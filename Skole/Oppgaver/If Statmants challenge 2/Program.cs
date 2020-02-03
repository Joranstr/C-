using System;

namespace If_Statmants_challenge_2
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Zero";
        static void Main(string[] args)
        {
            
            
        }
        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is "+ score);
                Console.WriteLine("It's new broken by "+ playerName);
            }
            else
            {
                Console.WriteLine("the olde highscore cood not be broken");
            }
        }
    }
}
