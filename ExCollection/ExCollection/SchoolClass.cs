namespace ExCollection
{
    public class SchoolClass
    {
        // TODO: Erstt.elle ein Property Schuelers, welches alle Schüler der Klasse in einer
        //       Liste speicher
        public List<Student> Schuelers { get; set; } = new();
        public string Name { get; set; }
        public string KV { get; set; }
        /// <summary>
        /// Fügt den Schüler zur Liste hinzu und setzt das Property KlasseNavigation
        /// des Schülers korrekt auf die aktuelle Instanz.
        /// </summary>
        /// <param name="s"></param>
        public void AddSchueler(Student s)
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
}
