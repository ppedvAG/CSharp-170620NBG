using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphie
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafik g1 = new Grafik();
            g1.Farbe = "Rot";

            Kreis k1 = new Kreis();
            k1.Farbe = "Gelb";
            k1.Radius = 12;

            Rechteck r1 = new Rechteck();
            r1.Farbe = "Grün";
            r1.Höhe = 20;
            r1.Breite = 40;

            g1.Zeichnen();
            k1.Zeichnen();
            r1.Zeichnen();

            Console.WriteLine("---------- Überschreiben -------------");

            Grafik g2 = new Kreis();
            g2.Farbe = "Blau";
            g2.Zeichnen();

            g2 = k1; // Referenzkopie
            g2.Zeichnen();

            Kreis k2 = (Kreis)g2;
            k2.Zeichnen();

            Console.WriteLine("---------- Verstecken -------------");

            g2 = new Rechteck();
            g2.Farbe = "Orange";
            g2.Zeichnen();

            Rechteck r2 = (Rechteck)g2;
            r2.Zeichnen();

            Console.WriteLine("---------- Anwendung -------------");

            Grafik[] meineGrafiken = new Grafik[5];
            meineGrafiken[0] = k1;
            meineGrafiken[1] = r1;
            meineGrafiken[2] = g1;
            meineGrafiken[3] = new Rechteck();
            meineGrafiken[4] = k2;

            foreach(Grafik item in meineGrafiken)
            {
                if(item is Kreis)
                {
                    Console.WriteLine("Das ist ein Kreis:");
                }
                else if(item is Rechteck)
                {
                    Console.WriteLine("Das ist ein Rechteck:");
                }
                item.Zeichnen();
            }

            ZeichneEtwas(k1);
            ZeichneEtwas(g1);

            Console.ReadKey();
        }

        public static void ZeichneEtwas(Grafik g)
        {
            g.Zeichnen();
        }

    }
}
