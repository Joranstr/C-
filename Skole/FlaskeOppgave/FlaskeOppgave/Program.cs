using System;

namespace FlaskeOppgave
{
    class Program
    {
        private static string[] operationNames = new[]
        {
            "Fylle flaske 1 fra springen",
            "Fylle flaske 2 fra springen",
            "Tømme flaske 1 i flaske 2",
            "Tømme flaske 2 i flaske 1",
            "Fylle opp flaske 2 med flaske 1",
            "Fylle opp flaske 1 med flaske 2",
            "Tømme flaske 1 (kaste vannet)",
            "Tømme flaske 2 (kaste vannet)",
        };
        static void Main(string[] args)
        {

            Bottle bottle1, bottle2;
            Bottle.SetButtleCapasity(out bottle1, out bottle2);
            //var bottle1 = new Bottle(5, 0);
            //var bottle2 = new Bottle(7, 0);
            //var wantedVolume = 5;
            int numberOfOperations = 1;
            while (true)
            {
                var isSolved = TryWithGivenNumberOfOperations(numberOfOperations, bottle1, bottle2, Bottle.WantedVolume);
                if (isSolved)
                {
                    break;
                }
                numberOfOperations++;
            }




        }

        private static bool TryWithGivenNumberOfOperations(int numberOfOperations, Bottle bottle1, Bottle bottle2,
            int wantedVolume)
        {
            Console.WriteLine($"Prøver med {numberOfOperations} operajon(er).");
            var operations = new int[numberOfOperations];
            while (true)
            {
                DoOperations(operations, bottle1, bottle2);
                var isSolved = IsSolved(bottle1, bottle2, wantedVolume, operations);
                if (isSolved) return true;
                var success = UpdateOperations(operations);
                if (!success) break;
            }

            return false;
        }

        private static bool UpdateOperations(int[] operations)
        {
            int i;
            for (i = operations.Length; i >= 0; i--)
            {
                if (operations[i] < 7)
                {
                    operations[i]++;
                    break;
                }

                operations[i] = 0;
            }

            return i != -1;
        }

        private static bool IsSolved(Bottle bottle1, Bottle bottle2, int wantedVolume, int[] operations)
        {
            if (bottle1.Content != wantedVolume && bottle2.Content != wantedVolume &&
                bottle2.Content + bottle1.Content != wantedVolume) return false;
            for (int i = 0; i < operations.Length; i++)
            {
                var operation = operations[i];
                Console.WriteLine((i + 1) + " " + operationNames[operation]);
            }
            return true;
        }

        private static void DoOperations(int[] operations, Bottle bottle1, Bottle bottle2)
        {
            bottle1.Empty();
            bottle2.Empty();

            for (int operationNo = 0; operationNo < 7; operationNo++)
            {
                if (operationNo == 0) bottle1.FillToTopFromTap();         // Fylle flaske 1 fra springen
                else if (operationNo == 1) bottle2.FillToTopFromTap();    // Fylle flaske 2 fra springen
                else if (operationNo == 2) bottle2.Fill(bottle1.Empty()); // Tømme flaske 1 i flaske 2 - 
                // Tanken er at Empty() returnerer hvor mye det var i flasken før den ble tømt
                else if (operationNo == 3) bottle1.Fill(bottle2.Empty()); // Tømme flaske 2 i flaske 1
                else if (operationNo == 4) bottle2.FillToTop(bottle1);    // Fylle opp flaske 2 med flaske 1
                // Tanken er at FillToTop tar en annen Bottle som parameter. Hvis det er nok, fyller den 
                // bottle2 og reduserer bottle1 tilsvarende. Hvis ikke gjør den ingenting.
                else if (operationNo == 5) bottle1.FillToTop(bottle2);    // Fylle opp flaske 1 med flaske 2
                else if (operationNo == 6) bottle1.Empty();               // Tømme flaske 1 (kaste vannet)
                else if (operationNo == 7) bottle2.Empty();               // Tømme flaske 2 (kaste vannet)

                //if (bottle1.Content == wantedVolume || bottle2.Content == wantedVolume)
                //{
                //    Console.WriteLine("Fant ønsket volum ved operasjon " + operationNo);
                //}
            }
        }
    }
}
