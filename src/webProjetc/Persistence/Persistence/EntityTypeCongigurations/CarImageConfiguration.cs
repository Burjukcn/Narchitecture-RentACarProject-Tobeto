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
    public class CarImageConfiguration : IEntityTypeConfiguration<CarImage>
    {
        public void Configure(EntityTypeBuilder<CarImage> builder)
        {
            builder.ToTable("CarImages").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.CarId).HasColumnName("CarId").IsRequired();
            builder.Property(x => x.ImagePath).HasColumnName("ImagePath").IsRequired();
            builder.Property(x => x.CreatedDate).HasColumnName("CreatedDate");
            builder.Property(x => x.UpdatedDate).HasColumnName("UpdatedDate");
            builder.Property(x => x.DeletedDate).HasColumnName("DeletedDate");

            builder.HasQueryFilter(x => !x.DeletedDate.HasValue);

            builder.HasOne(x => x.Car);
        }
    }
}
