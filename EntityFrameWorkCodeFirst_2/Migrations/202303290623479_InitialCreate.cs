namespace EntityFrameWorkCodeFirst_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ders",
                c => new
                    {
                        DersId = c.Int(nullable: false, identity: true),
                        DersAdı = c.String(),
                    })
                .PrimaryKey(t => t.DersId);
            
            CreateTable(
                "dbo.Ogrenci",
                c => new
                    {
                        OgrenciID = c.Int(nullable: false, identity: true),
                        Adı = c.String(),
                        Soyadi = c.String(),
                        OkulNo = c.String(),
                    })
                .PrimaryKey(t => t.OgrenciID);
            
            CreateTable(
                "dbo.Ogretmen",
                c => new
                    {
                        OgretmenID = c.Int(nullable: false, identity: true),
                        Adı = c.String(),
                        Soyadi = c.String(),
                        TCNo = c.String(),
                        DersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OgretmenID)
                .ForeignKey("dbo.Ders", t => t.DersId, cascadeDelete: true)
                .Index(t => t.DersId);
            
            CreateTable(
                "dbo.OgrenciDers",
                c => new
                    {
                        Ogrenci_OgrenciID = c.Int(nullable: false),
                        Ders_DersId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ogrenci_OgrenciID, t.Ders_DersId })
                .ForeignKey("dbo.Ogrenci", t => t.Ogrenci_OgrenciID, cascadeDelete: true)
                .ForeignKey("dbo.Ders", t => t.Ders_DersId, cascadeDelete: true)
                .Index(t => t.Ogrenci_OgrenciID)
                .Index(t => t.Ders_DersId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ogretmen", "DersId", "dbo.Ders");
            DropForeignKey("dbo.OgrenciDers", "Ders_DersId", "dbo.Ders");
            DropForeignKey("dbo.OgrenciDers", "Ogrenci_OgrenciID", "dbo.Ogrenci");
            DropIndex("dbo.OgrenciDers", new[] { "Ders_DersId" });
            DropIndex("dbo.OgrenciDers", new[] { "Ogrenci_OgrenciID" });
            DropIndex("dbo.Ogretmen", new[] { "DersId" });
            DropTable("dbo.OgrenciDers");
            DropTable("dbo.Ogretmen");
            DropTable("dbo.Ogrenci");
            DropTable("dbo.Ders");
        }
    }
}
