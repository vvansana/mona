namespace SharedKernelData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductClass : DbMigration
    {
        public override void Up()
        {
            CreateTable("dbo.Product",
                c => new
                {
                    ProductId = c.Int(nullable: false, identity: true),
                    ProductName = c.String(),
                    ProductDescription = c.String(),
                    ProductPrice = c.Decimal(nullable: true, precision: 2),
                    CreatedUtc = c.DateTime(nullable: false),
                    Created = c.DateTime(nullable: false, defaultValueSql: "GETDATE()"),
                    CategoryId = c.Int(nullable: true)

                })
                .PrimaryKey(x => x.ProductId);




            CreateTable("dbo.ProductImage",
                c => new
                {
                    ImageId = c.Int(nullable: false, identity: true),
                    ProductId = c.Int(nullable: false),
                    ImageUrl = c.String(nullable: true),
                    CreatedUtc = c.DateTime(nullable: false),

                })
                .PrimaryKey(x => x.ImageId)
                .ForeignKey("dbo.Product", x => x.ProductId, cascadeDelete: false);

           

        }

        public override void Down()
        {
            DropForeignKey("dbo.ProductImage", "ProductImage", "dbo.Product");
            DropTable("dbo.ProductImage");
            DropTable("dbo.Product");

            //DropColumn("dbo.Product", "ProductId");

        }
    }
}
