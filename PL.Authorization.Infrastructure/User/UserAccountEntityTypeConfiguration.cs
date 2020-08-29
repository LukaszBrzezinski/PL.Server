using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PL.Authorization.Application.User;

namespace PL.Authorization.Infrastructure.User
{
    internal class UserAccountEntityTypeConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> builder)
        {
            builder.ToTable("UserAccounts");

            builder.HasKey(ua => ua.UserId);

            builder.Property<string>("_login").HasColumnName("Login");
            builder.Property<string>("_login").HasColumnName("Password");
            builder.Property<string>("_login").HasColumnName("Email");
            builder.Property<string>("_login").HasColumnName("IsActive");
            builder.Property<string>("_login").HasColumnName("FirstName");
            builder.Property<string>("_login").HasColumnName("LastName");
        }
    }
}
