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
    public class ImageEntityConfiguration : IEntityTypeConfiguration<Image>
    {
        private readonly ISeedService _seedService;

        public ImageEntityConfiguration(ISeedService seedService)
            => _seedService = seedService;

        public void Configure(EntityTypeBuilder<Image> builder)
            => builder.HasData(_seedService.Images.Values.ToArray());
    }
}
