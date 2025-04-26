using Microsoft.EntityFrameworkCore;

namespace HelpDeskFlow.Models
{
    public class HelpDeskFlowContext : DbContext
    {
        public HelpDeskFlowContext(DbContextOptions<HelpDeskFlowContext> options) : base(options)
        {

        }

        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
    }
}
