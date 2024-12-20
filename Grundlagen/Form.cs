namespace Grundlagen
{
    // Die Klasse "Form1" repräsentiert die Benutzeroberfläche (Form) der Anwendung.
    public partial class Form1 : Form
    {
        // Ein Array zum Speichern der Kalorienwerte für bis zu 10 Tage.
        private int[] kalorienArray = new int[10];

        // Ein Index, der die aktuelle Position im Array verfolgt (wie viele Werte schon eingegeben wurden).
        private int index = 0;

        // Standardwert für das Bewegungsziel (z. B. 120 kcal).
        private int bewegungsziel = 120;

        // Konstruktor der Form1-Klasse, der die Form initialisiert.
        public Form1()
        {
            InitializeComponent(); // Initialisiert die Steuerelemente der Form (vom Designer generiert).
        }

        // Ereignis-Handler für den Button "Einlesen und anzeigen".
        private void btnTagesumsaetze_Click(object sender, EventArgs e)
        {
            // Prüft, ob noch Platz im Array für weitere Werte vorhanden ist.
            if (index < kalorienArray.Length)
            {
                string eingabe;
                eingabe = Console.ReadLine();

                try
                {
                    // Versucht, die Benutzereingabe in eine Zahl zu konvertieren.
                    int kalorienWert = Convert.ToInt32(eingabe);

                    // Speichert die Eingabe im Array an der aktuellen Indexposition.
                    kalorienArray[index] = kalorienWert;

                    // Erhöht den Index, um den nächsten Wert in die nächste Position zu speichern.
                    index++;

                    // Zeigt die eingegebenen Werte in der Textbox "txbAnzeige" an, getrennt durch Zeilenumbrüche.
                    txbAnzeige.Text = string.Join(Environment.NewLine, kalorienArray.Take(index));
                }
                catch (FormatException)
                {
                    // Zeigt eine Fehlermeldung an, wenn die Eingabe keine gültige Zahl ist.
                    MessageBox.Show("Bitte eine gültige Zahl eingeben.");
                }
                catch (OverflowException)
                {
                    // Zeigt eine Fehlermeldung an, wenn die Eingabe außerhalb des gültigen Bereichs liegt.
                    MessageBox.Show("Die eingegebene Zahl ist zu groß oder zu klein.");
                }
            }
            else
            {
                // Zeigt eine Fehlermeldung an, wenn bereits 10 Werte eingegeben wurden.
                MessageBox.Show("Es können maximal 10 Werte eingegeben werden.");
            }
        }

        // Ereignis-Handler für den Button "Korrigieren".
        private void btnKorrigieren_Click(object sender, EventArgs e)
        {
            try
            {
                // Liest die Benutzereingaben von der Konsole.
                Console.Write("Tag: ");
                int tag = Convert.ToInt32(Console.ReadLine());

                Console.Write("Neuer Wert: ");
                int neuerWert = Convert.ToInt32(Console.ReadLine());

                // Prüft, ob der eingegebene Tag im gültigen Bereich liegt (1 bis aktuelle Anzahl von Werten).
                if (tag >= 1 && tag <= index)
                {
                    // Aktualisiert den Wert im Array für den angegebenen Tag.
                    kalorienArray[tag - 1] = neuerWert;

                    // Aktualisiert die Anzeige in der Textbox "txbAnzeige".
                    txbAnzeige.Text = string.Join(Environment.NewLine, kalorienArray.Take(index));
                }
                else
                {
                    // Zeigt eine Fehlermeldung an, wenn der Tag außerhalb des gültigen Bereichs liegt.
                    MessageBox.Show("Ungültiger Tag. Bitte einen Wert zwischen 1 und " + index + " eingeben.");
                }
            }
            catch (FormatException)
            {
                // Zeigt eine Fehlermeldung an, wenn eine der Eingaben keine gültige Zahl ist.
                MessageBox.Show("Bitte gültige Zahlen für Tag und neuen Wert eingeben.");
            }
            catch (OverflowException)
            {
                // Zeigt eine Fehlermeldung an, wenn die Eingabe außerhalb des gültigen Bereichs liegt.
                MessageBox.Show("Die eingegebene Zahl ist zu groß oder zu klein.");
            }
        }

        // Ereignis-Handler für den Button "Ziel anpassen".
        private void btnZielAnpassen_Click(object sender, EventArgs e)
        {
            try
            {
                // Liest die Benutzereingabe von der Konsole.
                Console.Write("Neues Bewegungsziel: ");
                int neuesZiel = Convert.ToInt32(Console.ReadLine());

                // Aktualisiert das Bewegungsziel mit dem neuen Wert.
                bewegungsziel = neuesZiel;

                // Zeigt eine Bestätigungsmeldung mit dem neuen Bewegungsziel an.
                MessageBox.Show("Das Bewegungsziel wurde auf " + bewegungsziel + " kcal gesetzt.");
            }
            catch (FormatException)
            {
                // Zeigt eine Fehlermeldung an, wenn die Eingabe keine gültige Zahl ist.
                MessageBox.Show("Bitte eine gültige Zahl eingeben.");
            }
            catch (OverflowException)
            {
                // Zeigt eine Fehlermeldung an, wenn die Eingabe außerhalb des gültigen Bereichs liegt.
                MessageBox.Show("Die eingegebene Zahl ist zu groß oder zu klein.");
            }
        }

        // Ereignis-Handler für den Button "Auswerten".
        private void btnAuswerten_Click(object sender, EventArgs e)
        {
            // Prüft, ob mindestens ein Wert im Array eingegeben wurde.
            if (index > 0)
            {
                // Berechnet, wie viele Tage das Bewegungsziel erreicht oder überschritten wurde.
                int tageMitZiel = kalorienArray.Take(index).Count(kcal => kcal >= bewegungsziel);

                // Berechnet den Durchschnitt der eingegebenen Werte.
                double durchschnitt = kalorienArray.Take(index).Average();

                // Zeigt die Ergebnisse (Tage mit Zielerreichung und Durchschnittswert) in einer Meldung an.
                MessageBox.Show($"Tage mit Zielerreichung: {tageMitZiel}\nDurchschnitt pro Tag: {durchschnitt:F2} kcal");
            }
            else
            {
                // Zeigt eine Fehlermeldung an, wenn noch keine Werte eingegeben wurden.
                MessageBox.Show("Es wurden noch keine Werte eingegeben.");
            }
        }
    }
}