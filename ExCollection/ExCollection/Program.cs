using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Newtonsoft.Json;

namespace ExCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, SchoolClass> schoolClasses = new Dictionary<string, SchoolClass>();
            schoolClasses.Add("3AHIF", new SchoolClass() { Name = "3AHIF", KV = "KV1" });
            schoolClasses.Add("3BHIF", new SchoolClass() { Name = "3BHIF", KV = "KV2" });
            schoolClasses.Add("3CHIF", new SchoolClass() { Name = "3CHIF", KV = "KV3" });
            schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1001, LastName = "VN1", FirstName = "ZN1" });
            schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1002, LastName = "VN2", FirstName = "ZN2", MaximaleStudiendauer = 5 });
            schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1003, LastName = "VN3", FirstName = "ZN3", MaximaleStudiendauer = 2 });
            schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1004, LastName = "VN3", FirstName = "ZN3", MaximaleStudiendauer = 3 });
            schoolClasses["3AHIF"].AddSchueler(new Student() { Id = 1021, LastName = "VN3", FirstName = "ZN3", MaximaleStudiendauer = 1 });
            schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1011, LastName = "VN4", FirstName = "ZN4", MaximaleStudiendauer = 7 });
            schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1012, LastName = "VN5", FirstName = "ZN5", MaximaleStudiendauer = 2 });
            schoolClasses["3BHIF"].AddSchueler(new Student() { Id = 1013, LastName = "VN6", FirstName = "ZN6", MaximaleStudiendauer = 7 });

            Student s = schoolClasses["3AHIF"].Schuelers[0];
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");
            Console.WriteLine("3AHIF vor ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3AHIF"].Schuelers));
            s.ChangeKlasse(schoolClasses["3BHIF"]);
            Console.WriteLine("3AHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3AHIF"].Schuelers));
            Console.WriteLine("3BHIF nach ChangeKlasse:");
            Console.WriteLine(JsonConvert.SerializeObject(schoolClasses["3BHIF"].Schuelers));
            Console.WriteLine($"s sitzt in der Klasse {s.KlasseNavigation.Name} mit dem KV {s.KlasseNavigation.KV}.");

            KuerzesteStudiendauer(schoolClasses["3AHIF"]);
        }

        private static void KuerzesteStudiendauer(SchoolClass k)
        {
            // 1. Initialisierung mit Maximalwert
            // 2. Prüfung ob nächste Dauer kleiner oder größer ist.
            // 2.1 Wenn größer: nichts zu tun ; zum nächsten Schüler gehen.
            // 2.2 Wenn kleiner: überschreiben wir den ersten Wert mit dem neuen Minimum;

            int minWert = 7;
            foreach (Student item in k.Schuelers)
            {
                if (item.MaximaleStudiendauer < minWert)
                {
                    if (item is Student)
                    {
                        minWert = item.MaximaleStudiendauer;
                    }
                }
            }
            Console.WriteLine($"Minimale Studendauer der {k?.Name ?? "unbekannte Klasse"} ist {minWert}");
        }
    }
}
