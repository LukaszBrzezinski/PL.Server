using Microsoft.EntityFrameworkCore;
using PL.Authorization.Application.User;

namespace PL.Authorization.Infrastructure
{
    public class AuthorizationDbContext : DbContext
    {
        public DbSet<UserAccount> Users { get; set; }
        public AuthorizationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("auth");
            builder.ApplyConfigurationsFromAssembly(typeof(AuthorizationDbContext).Assembly);

            base.OnModelCreating(builder);
        }
    }
}
