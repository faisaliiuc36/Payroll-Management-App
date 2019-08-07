namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeNationalId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "NationalId", c => c.String(maxLength: 450));
            CreateIndex("dbo.Employees", "NationalId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Employees", new[] { "NationalId" });
            DropColumn("dbo.Employees", "NationalId");
        }
    }
}
