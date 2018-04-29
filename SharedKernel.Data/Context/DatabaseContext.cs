using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SharedKernelData.Entity;
using SharedKernel.Data.Context;

namespace SharedKernelData.Context
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("DefaultConnection")
        {
        }

        public DatabaseContext(string connectionString) : base(connectionString)
        {

        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<ProductImageEntity> ProductImages { get; set; }




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            //var entityConfigurations = typeof(ProductEntityConfiguration).Assembly.GetExportedTypes().Where(x => x.Name.Contains("EntityConfiguration"));
            //foreach(var entityConfiguration in entityConfigurations)
            //{
            //    var config = (entityConfiguration.GetType)Activator.CreateInstance(entityConfiguration);
            //    modelBuilder.Configurations.Add(entityConfiguration.gett);
            //}

            modelBuilder.Configurations.AddFromAssembly(typeof(ProductEntityConfiguration).Assembly);

            //modelBuilder.Configurations.Add(new ProductEntityConfiguration());
            //modelBuilder.Configurations.Add(new ProductImageEntityConfiguration());
            //modelBuilder.Configurations.Add(new CategoryEntityConfiguration());


        }
    }
}