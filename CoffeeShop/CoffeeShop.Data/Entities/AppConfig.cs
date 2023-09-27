using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Data.Entities
{
    public class AppConfig : IEntityTypeConfiguration<AppConfig>
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {

            builder.ToTable("AppConfigs");
            builder.HasKey(x => x.Key);

            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
