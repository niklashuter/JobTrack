using Microsoft.EntityFrameworkCore;
using JobTrack.Models;

namespace JobTrack.Data;

public class AppDbContext : DbContext
{
    public DbSet<JobApplication> JobApplications => Set<JobApplication>();
    public DbSet<Interview> Interviews => Set<Interview>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=jobtrack.db");
    }
}