using Microsoft.EntityFrameworkCore;
using Spg.DomainLinQ.App.Infrastructure;
using Spg.DomainLinQ.App.Services;

DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder();
optionsBuilder.UseSqlite("Data Source=./../../../School2000.db");

School2000Context db = new School2000Context(optionsBuilder.Options);
db.Database.EnsureDeleted();
db.Database.EnsureCreated();
db.Seed();

LinQService linQService = new(db);
linQService.Start();

Console.ReadLine();
