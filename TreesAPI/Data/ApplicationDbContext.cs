using Microsoft.EntityFrameworkCore;
using UserTestAPI.Models;

namespace UserTestAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<JournalException> JournalExceptions { get; set; }
        public DbSet<Node> Nodes { get; set; }
    }
}

