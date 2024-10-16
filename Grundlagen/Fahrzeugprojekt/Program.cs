using System;

namespace FahrzeugProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erstellen von Instanzen der abgeleiteten Klassen
            Auto meinAuto = new Auto("BMW", 2020, 4);
            Motorrad meinMotorrad = new Motorrad("Harley-Davidson", 2018, true);

            // Anzeigen der Details
            meinAuto.Anzeigen();
            meinMotorrad.Anzeigen();
        }
    }
}