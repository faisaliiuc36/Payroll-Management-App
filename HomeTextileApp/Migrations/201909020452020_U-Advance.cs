namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UAdvance : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Paytimes", "Advance_Id", "dbo.Advances");
            DropIndex("dbo.Paytimes", new[] { "Advance_Id" });
            DropColumn("dbo.Paytimes", "Advance_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Paytimes", "Advance_Id", c => c.Int());
            CreateIndex("dbo.Paytimes", "Advance_Id");
            AddForeignKey("dbo.Paytimes", "Advance_Id", "dbo.Advances", "Id");
        }
    }
}
