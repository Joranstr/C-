using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Startliste
{
    class RegistrationModel
    {
        public List<Registration> Registrations { get; private set; }
        public List<Club> Clubs { get; private set; }

        public RegistrationModel()
        {
            Registrations = new List<Registration>();
            Clubs = new List<Club>();
        }
        public void HandleLine(string csvLine)
        {
            var registration = new Registration(csvLine);
            Registrations.Add(registration); 
            var club = Clubs.FirstOrDefault(c => c.Name == registration.Club) ?? new Club(registration.Club);


            club.Registration.Add(registration);
            Clubs.Add(club);


            /*var registration = new Registration(csvLine);
            Registrations.Add(registration);

            Club clubSearchRestult = null;

            foreach (var club in Clubs)
            {
                if (club.Name == registration.Club)
                {
                    clubSearchRestult = club.Name;
                    break;
                }
            }*/


        }
    }
}
