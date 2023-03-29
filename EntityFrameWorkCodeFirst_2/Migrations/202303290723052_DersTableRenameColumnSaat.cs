namespace EntityFrameWorkCodeFirst_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DersTableRenameColumnSaat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ders", "DersSaati", c => c.Int(nullable: false));
            Sql("UPDATE Ders SET DersSaati = Saat");//veri kaybı olmasın diye
            DropColumn("dbo.Ders", "Saat");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ders", "Saat", c => c.Int(nullable: false));
            Sql("UPDATE Ders SET  Saat = DersSaati");//veri kaybı olmasın diye
            DropColumn("dbo.Ders", "DersSaati");
        }
    }
}
