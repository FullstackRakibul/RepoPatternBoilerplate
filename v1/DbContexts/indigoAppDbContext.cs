using Microsoft.EntityFrameworkCore;
using v1.DbContexts.Models;


namespace v1.DbContexts
{
    public class indigoAppDbContext : DbContext
    {
        public indigoAppDbContext(DbContextOptions<indigoAppDbContext> options)
            : base(options)
        {

        }

        public DbSet<PublicData> PublicData { get; set; }
    }
}
