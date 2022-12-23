using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * PhoneNumber
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class Student : EntityBase
    {
        // TODO: Implementation

        private List<Subject> _subjects = new();

        public Genders Gender { get; set; }
        public long RegistrationNumber { get; private set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address? Address { get; set; } = default!;
        public PhoneNumber? PhoneNumber { get; set; } = default!;

        private string? _accountName;

        public string? AccountName
        {
            get { return _accountName; }
            set { _accountName = LastName.Substring(0,4) + RegistrationNumber; }
        }


        public Guid Guid { get; private set; }

        public Student(Genders gender, 
            long registrationNumber, 
            string firstName, 
            string lastName, 
            string eMail)
        {
            Gender = gender;
            RegistrationNumber = registrationNumber;
            FirstName = firstName;
            LastName = lastName;
            EMail = eMail;
        }
        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }
    }
}
