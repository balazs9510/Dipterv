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
    public class UserRoleEntityConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private readonly ISeedService _seedService;

        public UserRoleEntityConfiguration(ISeedService seedService)
            => _seedService = seedService;

        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
            => builder.HasData(_seedService.UserRoles.ToArray());
    }
}
