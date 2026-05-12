using System;

namespace JobTrack.Models;

public class Interview
{
    public int Id { get; set; }

    // Verbindung zur Bewerbung
    public int JobApplicationId { get; set; }

    public DateTime Date { get; set; }

    public string Type { get; set; } = "Vor Ort"; 
    // Online, Vor Ort

    public string Location { get; set; } = string.Empty;

    public string ContactPerson { get; set; } = string.Empty;

    public string Notes { get; set; } = string.Empty;
}