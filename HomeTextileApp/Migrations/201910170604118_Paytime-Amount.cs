namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaytimeAmount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Paytimes", "Amount", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Paytimes", "Amount");
        }
    }
}
