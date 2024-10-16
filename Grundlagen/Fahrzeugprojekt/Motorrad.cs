using System;

namespace FahrzeugProjekt
{
    // Abgeleitete Klasse Motorrad
    class Motorrad : Fahrzeug
    {
        public bool HatBeiwagen { get; set; }

        // Konstruktor der abgeleiteten Klasse
        public Motorrad(string marke, int baujahr, bool hatBeiwagen)
            : base(marke, baujahr)
        {
            HatBeiwagen = hatBeiwagen;
        }

        // Überschreiben der Anzeigen-Methode
        public override void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine($"Hat Beiwagen: {HatBeiwagen}");
        }
    }
}