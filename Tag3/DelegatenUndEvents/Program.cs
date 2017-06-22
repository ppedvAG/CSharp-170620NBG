using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Program
    {

        public delegate void MeinDelegatTyp(int x);
        public delegate void MeinDelegatTyp2(int x,int y);
        public delegate int Berechnung(int zahl1, int zahl2);

        static void Main(string[] args)
        {
            //A(12);
            //C(9, 3);
            //MeinDelegatTyp del = A;
            //del += B; // Multicast-Delegat

            //MeinDelegatTyp2 del2 = new MeinDelegatTyp2(C);
            //del(12);

            #region Anwendugnsfall für einen Delegaten
            // 
            //Console.WriteLine("Bitte geben Sie einen Operator ein:");
            //string rechenzeichen = Console.ReadLine(); // z.B "+"
            //int zahl1 = 5;
            //int zahl2 = 10;
            //int ergebnis = 0;

            //if(rechenzeichen == "+")
            //{
            //    ergebnis = Add(zahl1, zahl2);
            //}
            //else if (rechenzeichen == "-")
            //{
            //    ergebnis = Sub(zahl1, zahl2);
            //}

            //Console.WriteLine(ergebnis);

            //Console.WriteLine("Bitte geben Sie einen Operator ein:");
            //string rechenzeichen = Console.ReadLine(); // z.B "+"
            //int zahl1 = 5;
            //int zahl2 = 10;
            //int ergebnis = 0;
            //Berechnung b = null;

            //if (rechenzeichen == "+")
            //{
            //    b = Add;
            //}
            //else if (rechenzeichen == "-")
            //{
            //    b = Sub;
            //}
            //ergebnis = b(zahl1, zahl2); // Ort der Ausführung ist nicht mehr in der Verzweigung
            //Console.WriteLine(ergebnis); 
            #endregion

            #region Action und Func

            //MeinDelegatTyp del = A;
            //Action<int> act = A;
            //Action<int,int> act2 = C; // Action -> Für alles, was void ist

            //Func<int, int, int> func = Add; // Func -> Für alles mit einer Rückgabe
            //Func<int, int, string> func2 = Demo;

            #endregion

            #region EventHandler
            //Func<int, int, int> func = Add;
            //func += Sub;
            //func(5, 10);

            //Func<object, MeineArgumente, int> neu = AddE;
            //neu += SubE;
            //AddE(null, new MeineArgumente { Zahl1 = 5, Zahl2 = 10 });

            //// -> EventHandler hat genau dieser Signatur
            //EventHandler e = new EventHandler(); 
            #endregion

            Button b = new Button();
            //b.Clicked += MeinButtonClick;
            //b.Clicked += Logging;
            b.ButtonClick += Logging;

            b.Click();
            b.Click();
            b.Click();

            //b.Clicked(null, EventArgs.Empty);   // Verboten !
            b.Click();
            b.Click();
            //b.Clicked = null;       // Absolut Verboten !
            b.Click();
            b.Click();

            Console.ReadKey();
        }

        private static void Logging(object sender, EventArgs e)
        {
            Console.WriteLine($"{DateTime.Now}: Button wurde gerade gedrückt");
        }

        private static void MeinButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("*click*");
        }

        #region Methoden
        public static void A(int zahl1)
        {
            Console.WriteLine("A");
        }
        public static void B(int zahl1)
        {
            Console.WriteLine("B");
        }
        public static void C(int zahl1, int zahl2)
        {
            Console.WriteLine("A");
        }

        public static int Add(int zahl1, int zahl2)
        {
            return zahl1 + zahl2;
        }
        public static int Sub(int zahl1, int zahl2)
        {
            return zahl1 - zahl2;
        }

        public static int AddE(object sender, MeineArgumente e)
        {
            return e.Zahl1 + e.Zahl1;
        }
        public static int SubE(object sender, MeineArgumente e)
        {
            e.NeuerString = "demo";
            return e.Zahl1 - e.Zahl1;
        }

        public static string Demo(int zahl1, int zahl2)
        {
            return "Demo";
        }
#endregion
    }
}
