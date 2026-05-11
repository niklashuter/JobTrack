namespace JobTrack.Models;

public class JobApplication
{
    public int id {get; set; }
    public string CompanyName { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public DateTime ApplicationDate { get; set; } = DateTime.Today;
    public string Status { get; set; } = "Offen";
    public string Notes { get; set; } = string.Empty;
}