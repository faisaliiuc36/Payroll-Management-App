namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkerTAU : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "TechnicalAllowance", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "TechnicalAllowance");
        }
    }
}
