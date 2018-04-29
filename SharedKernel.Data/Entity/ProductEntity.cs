
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace SharedKernelData.Entity
{

    public class ProductEntity : EntityBase
    {
        public int ProductId { get; set; }

        [ForeignKey("ProductCategoryId")]
        public CategoryEntity ProductCategory { get; set; }

        public int ProductCategoryId { get; set; }

        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal? ProductPrice { get; set; }

        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created { get; set; }
        public virtual List<ProductImageEntity> ProductImages { get; set; } 

    }



}