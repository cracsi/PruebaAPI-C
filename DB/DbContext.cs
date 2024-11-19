


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PruebaAPI_C.Entitites;

namespace PruebaAPI_C.DB
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
