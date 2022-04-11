using System;
using System.Collections.Generic;

namespace ObjectOrientedExplained
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1rood = 255;
            int l1groen = 0;
            int l1blauw = 255;

            int l2rood = 255;
            int l2groen = 255;
            int l2blauw = 0;

            Console.WriteLine(l1rood + l1groen + l1blauw);
            Console.WriteLine(l2rood + l2groen + l2blauw);

            Lampje led1 = new Lampje();
            led1.Rood = 255;
            led1.Groen = 0;
            led1.Blauw = 255;

            Lampje led2 = new Lampje() { Rood = 255, Groen = 255, Blauw = 0 };

            List<Lampje> lampjes = new List<Lampje>();
            lampjes.Add(led1);
            lampjes.Add(led2);

            foreach (Lampje l in lampjes)
            {
                l.print();
                l.ZetKleur(0, 0, 0);
            }

            foreach(Lampje l in lampjes)
            {
                l.print();
            }
        }
    }
}
