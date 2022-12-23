using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Bogus.DataSets.Name;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Date (?)
    /// * Lesson (int?)
    /// * Created
    /// * Guid
    /// * Grade (Note 1-5)
    /// (4P)
    /// </summary>
    public class Exam : EntityBase
    {
        // TODO: Implementation

        public DateTime? Date { get; set; }
        public int Lesson { get; set; }

        public DateTime? Created { get; set; }

        public Guid Guid { get; private set; }

        private int _grade;

        public int Grade
        {
            get { return _grade; }
            set { if (value >= 1 && value <= 5) { _grade = value; }; }
        }

        public Exam(DateTime date,
            int lesson,
            DateTime created,
            Guid guid,
            int grade)
        {
            Lesson = lesson;
            Created = created;
            Guid = guid;
            Grade = grade;
        }

    }
}
