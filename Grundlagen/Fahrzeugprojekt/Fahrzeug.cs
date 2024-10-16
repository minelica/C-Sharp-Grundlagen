using System;

namespace FahrzeugProjekt
{
    // Basisklasse Fahrzeug
    class Fahrzeug
    {
        // Eigenschaften (propertires) der Basisklasse
        public string Marke { get; set; }
        public int Baujahr { get; set; }

        // Konstruktor der Basisklasse
        public Fahrzeug(string marke, int baujahr)
        {
            Marke = marke;
            Baujahr = baujahr;
        }

        // Methode zum Anzeigen der Fahrzeugdetails
        public virtual void Anzeigen()
        {
            Console.WriteLine($"Marke: {Marke}, Baujahr: {Baujahr}");
        }
    }
}