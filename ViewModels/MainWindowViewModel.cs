using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using JobTrack.Data;
using JobTrack.Models;

namespace JobTrack.ViewModels;

public class MainWindowViewModel
{
    public ObservableCollection<JobApplication> Applications { get; } = new();

    // Eingabefelder
    public string NewCompanyName { get; set; } = "";
    public string NewPosition { get; set; } = "";

    // Verfügbare Statuswerte
    public List<string> StatusOptions { get; } = new()
    {
        "Offen",
        "Bewerbung gesendet",
        "Interview",
        "Angebot erhalten",
        "Abgelehnt"
    };

    // Ausgewählter Status
    public string SelectedStatus { get; set; } = "Offen";

    public MainWindowViewModel()
    {
        LoadApplications();
    }

    private void LoadApplications()
    {
        Applications.Clear();

        using var db = new AppDbContext();
        var data = db.JobApplications.ToList();

        foreach (var job in data)
        {
            Applications.Add(job);
        }
    }

    public void SaveApplication()
    {
        if (string.IsNullOrWhiteSpace(NewCompanyName) ||
            string.IsNullOrWhiteSpace(NewPosition))
        {
            return;
        }

        using var db = new AppDbContext();

        var application = new JobApplication
        {
            CompanyName = NewCompanyName,
            Position = NewPosition,
            Status = SelectedStatus,
            Notes = ""
        };

        db.JobApplications.Add(application);
        db.SaveChanges();

        // Eingabefelder zurücksetzen
        NewCompanyName = "";
        NewPosition = "";
        SelectedStatus = "Offen";

        LoadApplications();
    }
}