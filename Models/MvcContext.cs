using Microsoft.EntityFrameworkCore;

namespace TotalClean.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

        public DbSet<TotalClean.Models.Usuario> Usuario { get; set; }
        public DbSet<TotalClean.Models.Admin> Admin{ get; set; }
        public DbSet<TotalClean.Models.Oficina> Oficina { get; set; }
        //public DbSet<TotalClean.Models.Hogar> Hogar { get; set; }
    }
}