using Newtonsoft.Json;

namespace ExCollection
{
    public class Student : Person
    {

        public Student() : this(12) {}
        public Student(int id) : base(id) {}
        
        // TODO: Erstelle ein Proeprty KlasseNavigation vom Typ Klasse, welches auf
        //       die Klasse des Schülers zeigt.
        [JsonIgnore]
        public SchoolClass KlasseNavigation { get; set; }
        // Füge dann über das Proeprty die Zeile
        // [JsonIgnore]
        // ein, damit der JSON Serializer das Objekt ausgeben kann.

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
        public void ChangeKlasse(SchoolClass k)
        {
            if (k == null)
            {
                throw new ArgumentNullException("Klasse ist Null!"); 
            }
            
            KlasseNavigation.Schuelers.Remove(this);
            k.AddSchueler(this);
        }

        public override string GetArriveType()
        {
            return "Reist meist öffentlich an, oder mit dem Fahrrad.";
        }
    }
}
