namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Complience : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HTAdmins", "Complience", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.HTAdmins", "Complience");
        }
    }
}
