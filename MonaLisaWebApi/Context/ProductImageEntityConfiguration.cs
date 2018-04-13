using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using MonaLisaWebApi.Entity;

namespace MonaLisaWebApi.Context
{
    public class ProductImageEntityConfiguration : EntityTypeConfiguration<ProductImageEntity>
    {
        public ProductImageEntityConfiguration()
        {
            this.ToTable("ProductImage");
            this.HasKey<int>(x => x.ImageId)
                .Property(x => x.ImageId).HasColumnName("ImageId");
            this.Property(x => x.ImageUrl)
                .HasColumnName("ImageUrl");
            this.Property(x => x.ProductId).HasColumnName("ProductId");

           

        }
        
    }
}