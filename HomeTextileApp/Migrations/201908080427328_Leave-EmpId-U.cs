namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LeaveEmpIdU : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Leaves", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Leaves", new[] { "EmployeeId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Leaves", "EmployeeId");
            AddForeignKey("dbo.Leaves", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
