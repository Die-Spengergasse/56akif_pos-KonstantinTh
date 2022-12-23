using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * Gender
    /// * Guid
    /// (4P)
    /// </summary>
    public class Teacher : EntityBase
    {
        // TODO: Implementation

        public Genders Gender { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address? Address { get; set; } = default!;

        private List<Subject> _subjects = new();

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }

        public Teacher(Genders gender,
            string firstName,
            string lastName,
            string eMail)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
        }
    }
}
