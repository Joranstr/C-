using Oblig1;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Oblig_1
{
    public class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Person.StandarPeople();
            Helptext(true);
            KonsolKomando();

        }

        private static void KonsolKomando()
        {
            while (true)
            {
                string Kommmando = Console.ReadLine().ToLower();

                if (Kommmando == "hjelp") Helptext(false);
                else if (Kommmando == "list") ShowListOfPeople();
                else if (Kommmando == "id") ChoosePerson();
                else if (Kommmando == "clear")
                {
                    Console.Clear();
                    Main();
                }
                else if (Kommmando == "exit") Environment.Exit(0);
                else
                {
                    Console.WriteLine("Forsto ikke komando, venlikst skri inn gyldig komando.\nHvis du trenger trenger og se gyldige kommandoer skriv hjelp.");
                    KonsolKomando();
                };
            }
        }

        private static void ChoosePerson()
        {
            int ID = 0;
            Console.WriteLine("Please enter Id");
            string innkommando = Console.ReadLine();
            try
            {
                ID = Int32.Parse(innkommando);
                ShowPerson(ID);
            }
            catch
            {
                Console.WriteLine("Please enter a number");
            }

        }

        private static void ShowPerson(int ID)
        {

            foreach (var person in Person.Persons)
            {
                if (ID == person.Id) person.show();
            }

        }

        private static void ShowListOfPeople()
        {
            foreach (var person in Person.Persons)
            {
                person.show();
            }
        }


        public static void Helptext(bool args)
        {
            bool hjelpetekst = args;

            if (hjelpetekst == false)
            {
                Console.WriteLine("comando linjer");
                Console.WriteLine("help - viser tiljengelige comando linjer.");
                Console.WriteLine("liste - viser alle personer med id, fornavn, etter navn, fødselsår, dødsår og evt. forerdre å barn til persjoner og dem's id.");
                Console.WriteLine("id - gir mulighet til å viser besteme personene med mor far og dem's id");
                Console.WriteLine("clear - fjerner tidligere tekst");
                Console.WriteLine("exit - avlutter program");
            }
            else
            {
                Console.WriteLine("Kommando linjer");
                Console.WriteLine("help");
                Console.WriteLine("liste");
                Console.WriteLine("id");
                Console.WriteLine("clear");
                Console.WriteLine("exit");
            }
            KonsolKomando();
        }

        public static void slekt()
        {


        }
    }
}
