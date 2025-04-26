using Microsoft.EntityFrameworkCore;

namespace HelpDeskFlow.Models
{
    public class HelpDeskFlowContext : DbContext
    {
        public HelpDeskFlowContext(DbContextOptions<HelpDeskFlowContext> options) : base(options)
        {

        }
    }
}
