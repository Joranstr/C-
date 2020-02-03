using System;
using System.Xml;

namespace Moodle_Pure_puzzles_oppgave
{
    class Program
    {
        private static void Main()
        {
            Exercise1();
            Exercise2();
            Exercise3();
        }

        private static void Exercise3()
        {
            /*
                #            #
                 ##        ## 
                  ###    ###
                   ########
                   ########
                  ###    ###
                 ##        ##
                #            # 
            */

            var iValues = new[] {0, 1, 2, 3, 3, 2, 1, 0};
            foreach (var i in iValues) Row(i);
        }

        private static void Row(int i)
        {
            SpaceLøkke(i);
            HashLøkke(i+1);
            SpaceLøkke(12-i*4);
            HashLøkke(i+1);
            NewLine();
        }

        private static void Exercise2()
        {
            /*
                  ##
                 ####
                ######
               ########
               ########
                ######
                 ####
                  ##
             */

            for (int i = 4 - 1; i >= 0; i--)
            {
                SpaceLøkke(i);
                HashLøkke(8 - i * 2);
                NewLine();
            }

            for (int i = 0; i < 4; i++)
            {
                SpaceLøkke(i);
                HashLøkke(8 - i * 2);
                NewLine();
            }
            NewLine();
        }
        private static void Exercise1() 
        {
            /*
            ########
             ######
              ####
               ##
            */

            for (int i = 0; i < 4; i++)
            {
                SpaceLøkke(i);
                HashLøkke(8-i*2);
                NewLine();
            }
            NewLine();
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }
        private static void HashLøkke(int count)
        {
            for (int i = 0; i < count; i++) Hashtag();
            

        }
        private static void Hashtag()
        {
            Console.Write('#');
        }

        private static void SpaceLøkke(int count)
        {
            for (int i = 0; i < count; i++) Space();
        }
        private static void Space()
        {
            Console.Write(' ');
        }
    }
}
