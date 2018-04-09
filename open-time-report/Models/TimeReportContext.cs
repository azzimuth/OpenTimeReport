using Microsoft.EntityFrameworkCore;

namespace opentimereport.Models
{
    public class TimeReportContext : DbContext
    {
        public TimeReportContext(DbContextOptions<TimeReportContext> options) : base(options
        )
        {
        }

        public DbSet<TimeReport> TimeReports
        {
            get;
            set;
        }
    }
}