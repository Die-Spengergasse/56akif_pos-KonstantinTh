using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogus.DataSets.Name;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class SchoolClass : EntityBase
    {
        public string Name { get; set; } = string.Empty;

        public Teacher Kv { get; set; }

        private string? _department;

        public string? Department
        {
            get { return _department; }
            set { _department = Name.Substring(0,2); }
        }

        public Guid Guid { get; set; }

        private List<Student> _students = new();
        public void AddStudents(List<Student> students)
        {
            _students.AddRange(students);
        }

        private List<Subject> _subjects = new();

        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }

        public SchoolClass(string name, Teacher kv, string department, Guid guid)
        {
            Name = name;
            Kv = kv;
            Department = department;
            Guid = guid;
        }
    }
}
