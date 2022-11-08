using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Newtonsoft.Json;

namespace ExCollection.App
{
    public class Klasse
    {
        // TODO: Erstt.elle ein Property Schuelers, welches alle Schüler der Klasse in einer
        //       Liste speicher
        public List<Schueler> Schuelers { get; set; } = new();
        public string Name { get; set; }
        public string KV { get; set; }
        /// <summary>
        /// Fügt den Schüler zur Liste hinzu und setzt das Property KlasseNavigation
        /// des Schülers korrekt auf die aktuelle Instanz.
        /// </summary>
        /// <param name="s"></param>
        public void AddSchueler(Schueler s)
        {
            if (s == null)
            {
                throw new ArgumentNullException("Schueler war Null!");
            }
            if (Schuelers.Contains(s))
            {
                throw new ArgumentException("Schueler ist bereits in diese Klasse!");
            }
            
            Schuelers.Add(s);
            s.KlasseNavigation = this;
        }
    }
    public class Schueler
    {
        // TODO: Erstelle ein Proeprty KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        [JsonIgnore]
        public Klasse KlasseNavigation { get; set; }
        // Füge dann über das Proeprty die Zeile
        // [JsonIgnore]
        // ein, damit der JSON Serializer das Objekt ausgeben kann.
        public int Id { get; set; }
        public string Zuname { get; set; }
        public string Vorname { get; set; }

        public string FullName 
        {
            get 
            { 
                /*StringBuilder s = new StringBuilder();
                s.Append("");*/
                return $"Full Name: {Vorname} {Zuname}";
            }
        }

        public int MaximaleStudiendauer 
        { 
            get {return _maximaleStudiendauer;}
            set
            {
                if (value >= 1 && value <= 7)
                {
                    _maximaleStudiendauer = value;
                }
                else
                {
                    throw new ArgumentException("Studiendauer ungültig!");
                }
            }
        }
        private int _maximaleStudiendauer;
        /// <summary>
        /// Ändert die Klassenzugehörigkeit, indem der Schüler
        /// aus der alten Klasse, die in KlasseNavigation gespeichert ist, entfernt wird.
        /// Danach wird der Schüler in die neue Klasse mit der korrekten Navigation eingefügt.
        /// </summary>
        /// <param name="k"></param>
        public void ChangeKlasse(Klasse k)
        {
            if (k == null)
            {
                throw new ArgumentNullException("Klasse ist Null!"); 
            }
            
            KlasseNavigation.Schuelers.Remove(this);
            k.AddSchueler(this);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Klasse> klassen = new Dictionary<string, Klasse>();
            klassen.Add("3AHIF", new Klasse() { Name = "3AHIF", KV = "KV1" });
            klassen.Add("3BHIF", new Klasse() { Name = "3BHIF", KV = "KV2" });
            klassen.Add("3CHIF", new Klasse() { Name = "3CHIF", KV = "KV3" });
            klassen["3AHIF"].AddSchueler(new Schueler() { Id = 1001, Vorname = "VN1", Zuname = "ZN1" });
            klassen["3AHIF"].AddSchueler(new Schueler() { Id = 1002, Vorname = "VN2", Zuname = "ZN2", MaximaleStudiendauer = 5 });
            klassen["3AHIF"].AddSchueler(new Schueler() { Id = 1003, Vorname = "VN3", Zuname = "ZN3", MaximaleStudiendauer = 2 });
            klassen["3AHIF"].AddSchueler(new Schueler() { Id = 1004, Vorname = "VN3", Zuname = "ZN3", MaximaleStudiendauer = 3 });
            klassen["3AHIF"].AddSchueler(new Schueler() { Id = 1021, Vorname = "VN3", Zuname = "ZN3", MaximaleStudiendauer = 1 });
            klassen["3BHIF"].AddSchueler(new Schueler() { Id = 1011, Vorname = "VN4", Zuname = "ZN4", MaximaleStudiendauer = 7 });
            klassen["3BHIF"].AddSchueler(new Schueler() { Id = 1012, Vorname = "VN5", Zuname = "ZN5", MaximaleStudiendauer = 2 });
            klassen["3BHIF"].AddSchueler(new Schueler() { Id = 1013, Vorname = "VN6", Zuname = "ZN6", MaximaleStudiendauer = 7 });

            Schueler s = klassen["3AHIF"].Schuelers[0];
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
            Console.WriteLine("3AHIF vor ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            s.ChangeKlasse(klassen["3BHIF"]);
            Console.WriteLine("3AHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3AHIF"].Schuelers));
            Console.WriteLine("3BHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(klassen["3BHIF"].Schuelers));
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");

            KuerzesteStudiendauer(klassen["3AHIF"]);
        }

        private static void KuerzesteStudiendauer(Klasse k)
        {
            // 1. Initialisierung mit Maximalwert
            // 2. Prüfung ob nächste Dauer kleiner oder größer ist.
            // 2.1 Wenn größer: nichts zu tun ; zum nächsten Schüler gehen.
            // 2.2 Wenn kleiner: überschreiben wir den ersten Wert mit dem neuen Minimum;

            int minWert = 7;
            foreach (Schueler item in k.Schuelers)
            {
                if (item.MaximaleStudiendauer < minWert)
                {
                    minWert = item.MaximaleStudiendauer;
                }
            }
            Console.WriteLine($"Minimale Studendauer der {k?.Name ?? "unbekannte Klasse"} ist {minWert}");
        }
    }
}
