using System;

namespace FahrzeugProjekt
{
    // Abgeleitete Klasse Auto
    class Auto : Fahrzeug
    {
        public int AnzahlTueren { get; set; }

        // Konstruktor der abgeleiteten Klasse
        public Auto(string marke, int baujahr, int anzahlTueren)
            : base(marke, baujahr)
        {
            AnzahlTueren = anzahlTueren;
        }

        // Überschreiben der Anzeigen-Methode
        public override void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine($"Anzahl der Türen: {AnzahlTueren}");
        }
    }
}