using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Oblig_1
{
    class HelpList
    {
        private static void Helptext()
        {
            Console.WriteLine("comando linjer");
            Console.WriteLine("help - viser tiljengelige comando linjer.");
            Console.WriteLine("liste - viser alle personer med id, fornavn, etter navn, fødselsår, dødsår og evt. forerdre å barn til persjoner og dem's id.");
            Console.WriteLine("vis +id - viser besteme personene med mor far og dem's id");
        }
    }
}
