using Microsoft.EntityFrameworkCore;
using TicketingSys.Domain;

namespace TicketingSys.Data
{
    public class TicketingDbContext: DbContext
    {
        public TicketingDbContext(DbContextOptions<TicketingDbContext> dbContextOptions): base(dbContextOptions)
        {

        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<IssueSeverity> IssueSeverities { get; set; }
        public DbSet<IssueType> IssueTypes { get; set; }
        public DbSet<ResolutionStatus> ResolutionStatuses { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
