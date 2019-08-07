namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDutyRoster : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shifts", "InActive", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Employees", "IsWorker", c => c.Boolean(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "IsWorker", c => c.String());
            DropColumn("dbo.Shifts", "InActive");
        }
    }
}
