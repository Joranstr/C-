using System;
using System.Collections.Generic;
using System.IO;

namespace Startliste
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new RegistrationModel();
            var list = new List<Registration>();


            using (var file = new StreamReader("Startlist.csv"))
            {

                string line;
                int lineNo = 0;
                while ((line = file.ReadLine()) != null)
                {
                    if (lineNo == 0)
                    {
                        lineNo++;
                        continue;

                    }
                    //var registration = new Registration(line);
                    //list.Add(registration);

                    model.HandleLine(line);
                    //Console.WriteLine(model.Clubs);

                }

            }

            //Console.WriteLine(model.Clubs.Count);
            foreach (var club in model.Clubs)
            {
                if (club.Name == "") continue;
                Console.WriteLine(club.Name);
                foreach (var registration in club.Registration)
                {
                    Console.Write("  " + registration.StartNumber + " ");
                    Console.WriteLine(registration.Name + " ");
                }
            }
        }
    }
}
