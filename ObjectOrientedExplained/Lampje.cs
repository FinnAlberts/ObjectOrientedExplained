using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedExplained
{
    class Lampje
    {
        public int Rood { get; set; }

        public int Groen { get; set; }

        public int Blauw { get; set; }

        public string Naam { get; set; }

        public void print()
        {
            Console.WriteLine("Lampje heeft totaal " + Rood + Groen + Blauw);
        }

        public void ZetKleur(int r, int g, int b)
        {
            Rood = r;
            Groen = g;
            Blauw = b;
        }
    }
}
