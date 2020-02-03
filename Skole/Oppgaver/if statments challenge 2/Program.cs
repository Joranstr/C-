using System;

namespace if_statments_challenge_2
{
    class Program
    {
        private static int Highscore = 50;
        static string HighscoreHolder = "Zero";
        public static int PlayerScore;
        private static string PlayerName="";

        static void Main(string[] args)
        {
            Console.WriteLine("What the players name?");
            var PlayerName = Console.ReadLine();
            Console.WriteLine("Enter PlayerScore");
            PlayerScore = Convert.ToInt32(Console.ReadLine());
            Players();
            HighscoreCompare();

        }
        public static void HighscoreCompare(int Highscore, string higgscroeholder)
        {
            if (PlayerScore> Highscore)
            {
                Highscore = PlayerScore;
                HighscoreHolder = PlayerName;
                Console.WriteLine(Highscore, PlayerName);

            }
            else if (PlayerScore<Highscore)
            {
                return;
            }
        }
        public static int Players()
        {
            
            var PLayerScoreParseSuccses = int.TryParse(Console.ReadLine(), out PlayerScore);
            if (PLayerScoreParseSuccses)
                Console.WriteLine("PLayerScoreParseSuccses "+PLayerScoreParseSuccses);
            else
                Console.WriteLine("PLayerScoreParseSuccses did not parse");
            return PlayerScore;


        }

    }
}
