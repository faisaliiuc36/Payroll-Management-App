namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Holiday_U : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Holidays", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Holidays", new[] { "EmployeeId" });
            AddColumn("dbo.Holidays", "DepartmentId", c => c.Int(nullable: false));
            AddColumn("dbo.Holidays", "HolidayReasons", c => c.String());
            AddColumn("dbo.Holidays", "From", c => c.DateTime(nullable: false));
            AddColumn("dbo.Holidays", "To", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Holidays", "DepartmentId");
            AddForeignKey("dbo.Holidays", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            DropColumn("dbo.Holidays", "EmployeeId");
            DropColumn("dbo.Holidays", "Date");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Holidays", "Date", c => c.DateTime(nullable: false));
            AddColumn("dbo.Holidays", "EmployeeId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Holidays", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Holidays", new[] { "DepartmentId" });
            DropColumn("dbo.Holidays", "To");
            DropColumn("dbo.Holidays", "From");
            DropColumn("dbo.Holidays", "HolidayReasons");
            DropColumn("dbo.Holidays", "DepartmentId");
            CreateIndex("dbo.Holidays", "EmployeeId");
            AddForeignKey("dbo.Holidays", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
    }
}
