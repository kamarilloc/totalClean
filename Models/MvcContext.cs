using Microsoft.EntityFrameworkCore;

namespace TotalClean.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

        
    }
}