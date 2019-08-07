namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _04082019 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.LeaveStores", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.LeaveStores", new[] { "EmployeeId" });
            AddColumn("dbo.LeaveTypes", "IsIncremental", c => c.Boolean(nullable: false));
            AddColumn("dbo.LeaveTypes", "DaysCountForEL", c => c.Int(nullable: false));
            AddColumn("dbo.LeaveStores", "Year", c => c.Int(nullable: false));
            AddColumn("dbo.LeaveStores", "IsSingleEmployee", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LeaveStores", "EmployeeId", c => c.String());
            DropColumn("dbo.Employees", "IsEdited");
            DropColumn("dbo.LeaveTypes", "Count");
            DropColumn("dbo.LeaveStores", "Spent");
            DropColumn("dbo.LeaveStores", "LeaveId");
            DropColumn("dbo.LeaveStores", "IsManual");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LeaveStores", "IsManual", c => c.Boolean(nullable: false));
            AddColumn("dbo.LeaveStores", "LeaveId", c => c.Int(nullable: false));
            AddColumn("dbo.LeaveStores", "Spent", c => c.Int(nullable: false));
            AddColumn("dbo.LeaveTypes", "Count", c => c.Int(nullable: false));
            AddColumn("dbo.Employees", "IsEdited", c => c.Boolean(nullable: false));
            AlterColumn("dbo.LeaveStores", "EmployeeId", c => c.Int(nullable: false));
            DropColumn("dbo.LeaveStores", "IsSingleEmployee");
            DropColumn("dbo.LeaveStores", "Year");
            DropColumn("dbo.LeaveTypes", "DaysCountForEL");
            DropColumn("dbo.LeaveTypes", "IsIncremental");
            CreateIndex("dbo.LeaveStores", "EmployeeId");
            AddForeignKey("dbo.LeaveStores", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
