namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeDueU : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.EmployeeDues", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeDues", new[] { "EmployeeId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.EmployeeDues", "EmployeeId");
            AddForeignKey("dbo.EmployeeDues", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
