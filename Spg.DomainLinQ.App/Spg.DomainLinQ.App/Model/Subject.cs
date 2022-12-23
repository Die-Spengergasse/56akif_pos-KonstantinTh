using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description
    /// (4P)
    /// </summary>
    public class Subject : EntityBase
    {

        public string Description { get; set; } = string.Empty;
        
        private List<Teacher> _teachers = new();
        private List<Exam> _exams = new();
        private List<Student> _students = new();

        public void AddSubjects(List<Exam> exams)
        {
            _exams.AddRange(exams);
        }


        public void AddTeachers(List<Teacher> teachers)
        {
            _teachers.AddRange(teachers);
        }


        public void AddStudents(List<Student> students)
        {
            _students.AddRange(students);
        }

        public Subject(string description)
        {
            Description = description;
        }
    }
}
