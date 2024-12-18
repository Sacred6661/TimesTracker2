using Microsoft.EntityFrameworkCore;
using TimesTracker2.Data.Enteties;

namespace TimesTracker2.Data
{
    public class TimeTrackerDbContext : DbContext
    {
        public  DbSet<Project> Projects { get; set; }
        public  DbSet<TimeTracker> TimeTrackers { get; set; }

        public TimeTrackerDbContext(DbContextOptions<TimeTrackerDbContext> options) : base(options)
        {
        }
    }
}
