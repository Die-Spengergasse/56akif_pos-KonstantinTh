using Bogus;
using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Infrastructure
{
    /// <summary>
    /// * DB-Sets (1P)
    /// * Constructors (1P)
    /// * Methoden (2P)
    /// Den Inhalt der Seed-Methode, nach vollständiger implementierung, einkommentieren
    /// </summary>
    public class School2000Context : DbContext
    {
        // TODO: Implementation

        public School2000Context(object nonsense)
        { }

        public void Seed()
        {
        //    Randomizer.Seed = new Random(103435);

        //    var departments = new string[] { "HIF", "AIF", "KIF", "CIF", "BIF", "HBGM" };
        //    var subjectsNames = new string[] { "POS", "D", "E", "AM", "DBI", "WIR", "NVS", "PRE", "RK", "RISL", "TINF" };


        //    // Seed Teachers
        //    var teachers = new Faker<Teacher>("de")
        //        .CustomInstantiator(f =>
        //        new Teacher(
        //            f.Name.FirstName(Bogus.DataSets.Name.Gender.Male),
        //            f.Name.LastName(),
        //            f.Internet.Email(),
        //            f.Random.Enum<Gender>(new Gender[] { Gender.NA }),
        //            f.Random.Guid(),
        //            new Address(
        //                f.Address.StreetName(),
        //                f.Address.ZipCode(),
        //                f.Address.City()
        //            )
        //        )
        //    )
        //    .Rules((f, t) =>
        //    {
        //        string firstName = String.Empty;
        //        if (t.Gender == Gender.FEMALE)
        //        {
        //            t.Firstname = f.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
        //        }
        //        t.LastChangeDate = f.Date.Between(new DateTime(2020, 1, 1), DateTime.Now).Date.OrNull(f, 0.3f);
        //    })
        //    .Generate(250)
        //    .ToList();
        //    Teachers.AddRange(teachers);
        //    SaveChanges();


        //    // Seed School Classes
        //    var schoolClasses = new Faker<SchoolClass>()
        //        .CustomInstantiator(f =>
        //        new SchoolClass(
        //            f.Random.Int(1, 8) + f.Random.String2(1, "ABCDEF") + f.Random.ListItem(departments),
        //            f.Random.ListItem(teachers),
        //            f.Random.Guid()
        //        )
        //    )
        //    .Rules((f, c) =>
        //    {
        //        c.LastChangeDate = f.Date.Between(new DateTime(2020, 1, 1), DateTime.Now).Date.OrNull(f, 0.3f);
        //    })
        //    .Generate(12)
        //    .GroupBy(c1 => c1.Name)
        //    .Select(g => g.First())
        //    .ToList();
        //    SchoolClasses.AddRange(schoolClasses);
        //    SaveChanges();


        //    // Seed Subjects
        //    var subjects = new Faker<Subject>("de")
        //        .CustomInstantiator(f =>
        //        new Subject(
        //            f.Random.ListItem(subjectsNames),
        //            f.Random.ListItem(schoolClasses)
        //        )
        //    )
        //    .Rules((f, su) =>
        //    {
        //        su.LastChangeDate = f.Date.Between(new DateTime(2020, 1, 1), DateTime.Now).Date.OrNull(f, 0.3f);
        //    })
        //    .Generate(90)
        //    .GroupBy(c1 => c1.Description)
        //    .Select(g => g.First())
        //    .ToList();
        //    Subjects.AddRange(subjects);
        //    SaveChanges();


        //    // Seed Students
        //    var students = new Faker<Student>("de")
        //        .CustomInstantiator(f =>
        //        new Student(
        //            f.Random.Int(11111, 99999),
        //            f.Random.Guid(),
        //            f.Name.FirstName(Bogus.DataSets.Name.Gender.Male),
        //            f.Name.LastName(),
        //            f.Internet.Email(),
        //            f.Random.Enum<Gender>(new Gender[] { Gender.NA }),
        //            f.Random.ListItem(schoolClasses),
        //            new Address(
        //                f.Address.StreetName(),
        //                f.Address.ZipCode(),
        //                f.Address.City()
        //            ),
        //            new PhoneNumber(f.Phone.PhoneNumberFormat())
        //        )
        //    )
        //    .Rules((f, s) =>
        //    {
        //        if (s.Gender == Gender.FEMALE)
        //        {
        //            s.Firstname = f.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
        //        }
        //        s.LastChangeDate = f.Date.Between(new DateTime(2020, 1, 1), DateTime.Now).Date.OrNull(f, 0.3f);
        //    })
        //    .Generate(240)
        //    .ToList();
        //    Students.AddRange(students);
        //    SaveChanges();


        //    foreach (Student item in students)
        //    {
        //        item.AddSubjects(subjects);
        //    }
        //    foreach (Teacher item in teachers)
        //    {
        //        item.AddSubject(new Faker().Random.ListItem(subjects));
        //    }
        //    SaveChanges();


        //    // Seed Exams
        //    var exams = new Faker<Exam>("de")
        //        .CustomInstantiator(f => 
        //        new Exam(
        //            f.Random.Guid(), 
        //            f.Date.Between(DateTime.Now, DateTime.Now.AddYears(1)).Date.OrNull(f, 0.2f),
        //            null,
        //            f.Random.Int(1, 5),
        //            f.Random.ListItem(subjects), 
        //            DateTime.Now)
        //        )
        //    .Rules((f, x) =>
        //    {
        //        if (x.SubjectNavigation.Description == "POS")
        //        {
        //            x.Grade = f.Random.Int(1, 3);
        //        }
        //        x.LastChangeDate = f.Date.Between(new DateTime(2020, 1, 1), DateTime.Now).Date.OrNull(f, 0.3f);
        //        if (x.Date.HasValue)
        //        {
        //            x.Lesson = f.Random.Int(1, 10);
        //        }
        //    })
        //    .Generate(180)
        //    .GroupBy(g => g.Date)
        //    .Select(g => g.First())
        //    .ToList();
        //    Exams.AddRange(exams);
        //    SaveChanges();
        }
    }
}
