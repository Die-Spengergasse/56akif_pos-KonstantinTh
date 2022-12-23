using Microsoft.EntityFrameworkCore.Query.Internal;
using Spg.DomainLinQ.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Services
{
    /// <summary>
    /// (8P)
    /// </summary>
    public class LinQService
    {
        private readonly School2000Context _db;
        public LinQService(School2000Context db)
        {
            _db = db;
        }

        public void Start()
        {
            // Gebe jenen Student mit der ID=12 zurück.
            var result01 = db.Students
                .SingleOrDefault(s => s.Id == 12);

            // Erstelle eine Liste aller Fächer, die eine negative Note haben.
            var result02 = db.Subjects
                .Where(s => s.Exams
                    .Any(s => s.Grade == 5));

            // Erstelle eine Liste aller Fächer, die eine negative Note in POS haben.
            var result03 = db.Subjects
                .Where(s => s.Subjects
                    .Any(s => s.Subjects.Description == "POS" && s.Exam.Grade == 5));

            // Erstelle eine Liste aller Fächer, die nur positive Noten haben.
            var result04 = db.Subjects
                .Where(s => s.Subjects
                    .Any(s.Exam.Grade <= 5));

            // Erstelle eine Liste aller Lehrer, die POS unterrichten
            var result05 = db.Teachers
                .Include(t => t.Subjects
                    .Where(s => s.Description
                        .Any(d => d.Description == "POS")));

            // Erstelle eine Liste aller Students mit einer "hotmail"-E-Mail-Adresse
            var result06 = db.Students
                    .Where(s => s.EMail
                        .Any(s => s.Email.contains("hotmail")));

            // Ermittle die schlechteste Note im Fach POS
            var result07 = db.Subjects
                    .Where(s => s.Description == "POS" && s.Exam.Grade == 4);

            // Ermittle den Notendurchschnitt im Fach DBI
            var result08 = string.Empty;
        }
    }
}
