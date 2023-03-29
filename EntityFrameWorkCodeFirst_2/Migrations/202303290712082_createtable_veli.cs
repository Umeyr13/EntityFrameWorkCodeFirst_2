namespace EntityFrameWorkCodeFirst_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createtable_veli : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Veli",
                c => new
                    {
                        VeliID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        SoyAd = c.String(),
                    })
                .PrimaryKey(t => t.VeliID);
            
            AddColumn("dbo.Ogrenci", "Veli_VeliID", c => c.Int());
            CreateIndex("dbo.Ogrenci", "Veli_VeliID");
            AddForeignKey("dbo.Ogrenci", "Veli_VeliID", "dbo.Veli", "VeliID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogrenci", "Veli_VeliID", "dbo.Veli");
            DropIndex("dbo.Ogrenci", new[] { "Veli_VeliID" });
            DropColumn("dbo.Ogrenci", "Veli_VeliID");
            DropTable("dbo.Veli");
        }
    }
}
