using System;

namespace Grundlagen
{
    class Grundlagen
    {
        static void Main(string[] args)
        {
            // Variablen und Datentypen
            int zahl = 10;
            double pi = 3.14;
            string text = "Hallo, Welt!";
            bool istWahr = true;
            char zeichen = 'A';

            Console.WriteLine("Zahl: " + zahl);
            Console.WriteLine("Pi: " + pi);
            Console.WriteLine("Text: " + text);
            Console.WriteLine("Ist wahr: " + istWahr);
            Console.WriteLine("Zeichen: " + zeichen);

            // Bedingungen
            if (zahl > 5)
            {
                Console.WriteLine("Die Zahl ist größer als 5.");
            }
            else
            {
                Console.WriteLine("Die Zahl ist 5 oder kleiner.");
            }

            // Schleifen
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Schleifenindex: " + i);
            }

            // Methoden
            int summe = Addiere(zahl, 20);
            Console.WriteLine("Summe: " + summe);
        }

        // Methode zum Addieren von zwei Zahlen
        static int Addiere(int a, int b)
        {
            return a + b;
        }
    }
}