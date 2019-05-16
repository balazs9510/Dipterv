using DAL.Entities;
using DAL.SeedServices;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.EntityConfigurations
{
    public class UserEntityConfiguration : IEntityTypeConfiguration<User>
    {
        private readonly ISeedService _seedService;

        public UserEntityConfiguration(ISeedService seedService)
            => _seedService = seedService;

        public void Configure(EntityTypeBuilder<User> builder)
            => builder.HasData(_seedService.Users.Values.ToArray());
    }
}
