namespace EntityFrameWorkCodeFirst_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droptelefonVeli : DbMigration
    {

        public override void Up()
        {
            CreateTable(
               "dbo.VeliBackup",
               c => new
               {
                   VeliID = c.Int(nullable: false, identity: false),//false yaptık
                   Ad = c.String(),
                   SoyAd = c.String(),
                   Telefon = c.String(),
               })
            .PrimaryKey(t => t.VeliID);

            Sql("INSERT INTO VeliBackup (VeliID,Ad,SoyAd,Telefon) SELECT VeliID,Ad,SoyAd,Telefon FROM Veli");

            DropColumn("dbo.Veli", "Telefon");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Veli", "Telefon", c => c.String());
        }
    }
}
