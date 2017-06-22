using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            #region List<T>
            //int[] meineZahlen = new int[3];
            //meineZahlen[0] = 9;
            //meineZahlen[1] = 12;
            //meineZahlen[2] = 8;

            //Console.WriteLine(meineZahlen[1]);

            //List<int> zahlenliste = new List<int>();
            //zahlenliste.Add(9);
            //zahlenliste.Add(12);
            //zahlenliste.Add(8);

            //Console.WriteLine(zahlenliste[1]);
            #endregion

            #region Stack<T>

            //LIFO - Struktur

            //Stack<int> meinStack = new Stack<int>();

            //meinStack.Push(9); //Hinzufügen
            //meinStack.Push(12);
            //meinStack.Push(3);
            //meinStack.Push(7);

            //Console.WriteLine(meinStack.Pop()); // Element vom Stapel runternehmen
            //Console.WriteLine(meinStack.Pop()); 
            //Console.WriteLine(meinStack.Pop()); 
            //Console.WriteLine(meinStack.Pop()); 


            #endregion

            #region Queue<T>

            // FIFO - Struktur

            //Queue<string> meineQueue = new Queue<string>();

            //meineQueue.Enqueue("Hallo"); // Einreihen
            //meineQueue.Enqueue("Welt");
            //meineQueue.Enqueue("!");

            //Console.WriteLine(meineQueue.Dequeue()); // Herausnehmen
            //Console.WriteLine(meineQueue.Dequeue());
            //Console.WriteLine(meineQueue.Dequeue());

            #endregion

            #region Dictionary<TKey,TValue>

            Dictionary<string, string> Hauptstädte = new Dictionary<string, string>();

            Hauptstädte.Add("Deutschland", "Berlin");
            Hauptstädte.Add("Österreich", "Wien");
            Hauptstädte.Add("Italien", "Rom");
            Hauptstädte.Add("Bulgarien", "Sofia");
            Hauptstädte.Add("Ungarn", "Budapest");
            Hauptstädte.Add("Tschechien", "Prag");
            Hauptstädte.Add("Frankreich", "Paris");
            Hauptstädte.Add("Spanien", "Madrid");
            Hauptstädte.Add("Griechenland", "Athen");

            if(Hauptstädte.ContainsKey("Bananenrepublik"))
                Console.WriteLine(Hauptstädte["Bananenrepublik"]);
            else
                Console.WriteLine("Bananenrepublik ist leider nicht vorhanden");

            //Mini-Übung: Benutzer gibt ein Land ein -> passende Hauptstadt ausgeben

            #endregion

            int[] zahlen = { 12, 5, 2, 88, 99, 12345 };
            Console.WriteLine(GC.GetTotalMemory(false));

            zahlen = null; // "löschen"
            GC.Collect();
            Console.WriteLine(GC.GetTotalMemory(false));


            Console.ReadKey();
        }
    }
}
