namespace EntityFrameWorkCodeFirst_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class veliTableAddColumnTelefon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Veli", "Telefon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Veli", "Telefon");
        }
    }
}
