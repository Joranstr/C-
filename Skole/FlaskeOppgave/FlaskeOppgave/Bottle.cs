using System;
using System.Collections.Generic;
using System.Text;

namespace FlaskeOppgave
{
    class Bottle
    {
        public int Capasity { get; private set; }
        public int Content { get; private set; }
        public static int WantedVolume { get; set; }
        public Bottle(int capasity, int content)
        {
            Capasity = capasity;
            Content = content;
        }
        public int Empty()
        {
            var content = Content;
            Content = 0;
            return Content;
        }

        public void Fill(int volume)
        {
            Content = Math.Min(Content + volume, Capasity);
        }

        public void FillToTopFromTap()
        {
            Content = Capasity;
        }

        public void FillToTop(Bottle bottle)
        {
            var maxFillVolume = Capasity - Content;
            var realFillVolume = Math.Min(maxFillVolume, bottle.Content);
            Content += realFillVolume;
            bottle.Content -= realFillVolume;
        }
        public static void SetButtleCapasity(out Bottle bottle1, out Bottle bottle2)
        {
            Console.WriteLine("Bottle1 Capasity?");
            bottle1 = new Bottle(int.Parse(Console.ReadLine()), 0);
            Console.WriteLine("Bottle2 Capasity?");
            bottle2 = new Bottle(int.Parse(Console.ReadLine()), 0);
            Console.WriteLine("Wanted Volume?");
            WantedVolume = int.Parse(Console.ReadLine());
        }
    }
}
