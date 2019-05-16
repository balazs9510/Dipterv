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
    public class ServiceTypeEntityConfiguration : IEntityTypeConfiguration<ServiceType>
    {
        private readonly ISeedService _seedService;

        public ServiceTypeEntityConfiguration(ISeedService seedService)
            => _seedService = seedService;

        public void Configure(EntityTypeBuilder<ServiceType> builder)
            => builder.HasData(_seedService.ServiceTypes.Values.ToArray());
    }
}
