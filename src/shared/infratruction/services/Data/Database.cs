using API_EM_C_.src.user.domain.entity.v1;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace API_EM_C_.src.shared.infrastructure.services.Data
{
    public class DatabaseContext : DbContext
    {
        private IConfiguration _configuration;

        public DbSet<UserEntity> Users { get; set; }

        public DatabaseContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var typeDatabase = _configuration["TypeDatabase"];
            var conectionString = _configuration.GetConnectionString(typeDatabase);

            if (typeDatabase == "Postgres")
            {
                optionsBuilder.UseNpgsql(conectionString);
            }
        }
    }
}
