
using SharedKernelData.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedKernel.Data.Context
{
    public class CategoryEntityConfiguration : EntityTypeConfiguration<CategoryEntity>
    {
        public CategoryEntityConfiguration()
        {
            this.ToTable("Category");
            this.HasKey<int>(x => x.CategoryId);
            this.Property(x => x.Created)
                .HasColumnName("Created")
                .HasColumnType("datetime").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
            this.Property(x => x.Name)
                .HasColumnName("Name");
            this.Property(x => x.Description)
                .HasColumnName("Description");
           

        }
    }
}
