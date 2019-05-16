using DAL.SeedServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.EntityConfigurations
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        private readonly ISeedService _seedService;

        public RoleEntityConfiguration(ISeedService seedService)
            => _seedService = seedService;

        public void Configure(EntityTypeBuilder<IdentityRole> builder)
            => builder.HasData(_seedService.Roles.Values.ToArray());
    }
}
