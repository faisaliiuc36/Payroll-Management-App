namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emp_IdU : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LeaveStores", "EmployeeId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.LeaveStores", "EmployeeId", c => c.String());
        }
    }
}
