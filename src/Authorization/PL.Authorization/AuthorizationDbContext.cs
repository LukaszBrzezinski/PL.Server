using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PL.Authorization.Application.User;

namespace PL.API.Authorization
{
    public class AuthorizationDbContext : DbContext
    {
        public DbSet<UserAccount> Users { get; set; }
        public AuthorizationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
