using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityTypeCongigurations
{
    public class ModelConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.ToTable("Models").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.BrandId).HasColumnName("BrandId");
            builder.Property(x => x.Name).HasColumnName("Name");
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(x => x.DeletedDate).HasColumnName("DeletedDate");

            builder.HasQueryFilter(x => !x.DeletedDate.HasValue);

            builder.HasOne(x => x.Brand);
            builder.HasMany(x => x.Cars);
        }
    }
}

