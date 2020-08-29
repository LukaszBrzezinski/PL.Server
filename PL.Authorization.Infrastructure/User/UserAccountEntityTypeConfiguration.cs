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

            builder.Property<string>("Login").HasColumnName("Login");
            builder.Property<string>("Password").HasColumnName("Password");
            builder.Property<string>("Email").HasColumnName("Email");
            builder.Property<string>("IsActive").HasColumnName("IsActive");
            builder.Property<string>("FirstName").HasColumnName("FirstName");
            builder.Property<string>("LastName").HasColumnName("LastName");
        }
    }
}
