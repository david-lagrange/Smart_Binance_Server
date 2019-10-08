using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    class ApplicationUsersConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {

        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.ToTable("ApplicationUsers");
            builder.HasData(
                new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Name = "David Lagrange",
                    Age = 24
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Name = "Sierra Seal",
                    Age = 24
                },
                new ApplicationUser
                {
                    Id = Guid.NewGuid(),
                    Name = "Roma Michele",
                    Age = 5
                }
            );
          
        }
    }
}
