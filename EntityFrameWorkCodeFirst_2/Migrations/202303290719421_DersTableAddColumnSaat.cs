namespace EntityFrameWorkCodeFirst_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DersTableAddColumnSaat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ders", "Saat", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ders", "Saat");
        }
    }
}
