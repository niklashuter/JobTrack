using System;
using JobTrack.Data;

Console.WriteLine("Starte Datenbank...");

using var db = new AppDbContext();

db.Database.EnsureCreated();

var application = new JobTrack.Models.JobApplication
{
    CompanyName = "ExampleAG",
    Position = "Junior Software Developer",
    Status = "Offen",
    Notes = "TestBewerbung"
};

db.JobApplications.Add(application);
db.SaveChanges();

Console.WriteLine("Datenbank erstellt oder bereits vorhanden.");