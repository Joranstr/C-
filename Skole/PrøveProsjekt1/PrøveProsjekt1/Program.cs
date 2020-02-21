using System;
using System.Collections.Generic;
using System.IO;

namespace PrøveProsjekt1
{
    class Program
    {

        public static List<int> MathResults = new List<int>();
        static void Main(string[] args)
        {
            var model = new RegistrationModel();
            var registrationsList = new List<Registration>();


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
                    registrationsList.Add(RegistrationModel);
                    Console.WriteLine(registrationsList.Count);
                    //Console.WriteLine(model.Clubs);

                }

            }
            

        }
 
    }
}
