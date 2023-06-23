namespace TurboTaskk.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarBanTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BanTypeName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarColorId = c.Int(nullable: false),
                        CarModelId = c.Int(nullable: false),
                        IsNew = c.Boolean(nullable: false),
                        CarBanTypeId = c.Int(nullable: false),
                        DistanceKM = c.Single(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CreatedYear = c.DateTime(nullable: false),
                        ImagePath = c.String(),
                        FuelTypeId = c.Int(nullable: false),
                        Engine = c.String(nullable: false),
                        FuelType_FuelTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarBanTypes", t => t.CarBanTypeId, cascadeDelete: true)
                .ForeignKey("dbo.CarColors", t => t.CarColorId, cascadeDelete: true)
                .ForeignKey("dbo.CarFuelTypes", t => t.FuelTypeId, cascadeDelete: true)
                .ForeignKey("dbo.CarFuelTypes", t => t.FuelType_FuelTypeId)
                .ForeignKey("dbo.CarModels", t => t.CarModelId, cascadeDelete: true)
                .Index(t => t.CarColorId)
                .Index(t => t.CarModelId)
                .Index(t => t.CarBanTypeId)
                .Index(t => t.FuelTypeId)
                .Index(t => t.FuelType_FuelTypeId);
            
            CreateTable(
                "dbo.CarColors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ColorName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CarFuelTypes",
                c => new
                    {
                        FuelTypeId = c.Int(nullable: false, identity: true),
                        FuelName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.FuelTypeId);
            
            CreateTable(
                "dbo.CarModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ModelName = c.String(nullable: false, maxLength: 30),
                        CarBrandId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarBrands", t => t.CarBrandId, cascadeDelete: true)
                .Index(t => t.CarBrandId);
            
            CreateTable(
                "dbo.CarBrands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarModelId", "dbo.CarModels");
            DropForeignKey("dbo.CarModels", "CarBrandId", "dbo.CarBrands");
            DropForeignKey("dbo.Cars", "FuelType_FuelTypeId", "dbo.CarFuelTypes");
            DropForeignKey("dbo.Cars", "FuelTypeId", "dbo.CarFuelTypes");
            DropForeignKey("dbo.Cars", "CarColorId", "dbo.CarColors");
            DropForeignKey("dbo.Cars", "CarBanTypeId", "dbo.CarBanTypes");
            DropIndex("dbo.CarModels", new[] { "CarBrandId" });
            DropIndex("dbo.Cars", new[] { "FuelType_FuelTypeId" });
            DropIndex("dbo.Cars", new[] { "FuelTypeId" });
            DropIndex("dbo.Cars", new[] { "CarBanTypeId" });
            DropIndex("dbo.Cars", new[] { "CarModelId" });
            DropIndex("dbo.Cars", new[] { "CarColorId" });
            DropTable("dbo.CarBrands");
            DropTable("dbo.CarModels");
            DropTable("dbo.CarFuelTypes");
            DropTable("dbo.CarColors");
            DropTable("dbo.Cars");
            DropTable("dbo.CarBanTypes");
        }
    }
}
