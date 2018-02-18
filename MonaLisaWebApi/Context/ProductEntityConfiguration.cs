using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using MonaLisaWebApi.Models;

namespace MonaLisaWebApi.Context
{
    public class ProductEntityConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductEntityConfiguration()
        {
            this.ToTable("Product");
            this.HasKey<int>(x => x.ProductId);
            this.Property(x => x.Created)
                .HasColumnName("Created")
                .HasColumnType("datetime").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            this.Property(x => x.ProductName)
                .HasColumnName("ProductName");
            this.Property(x => x.ProductDescription)
                .HasColumnName("ProductDescription");
            this.Property(x => x.ProductPrice)
                .HasColumnName("ProductPrice");             
            this.HasMany<ProductImage>(s => s.ProductImages);

        }
    }
}