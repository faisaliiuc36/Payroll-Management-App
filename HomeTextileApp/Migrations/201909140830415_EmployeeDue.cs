namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeDue : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeDues",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        DueCurrent = c.Double(nullable: false),
                        Paid = c.Boolean(nullable: false),
                        Due = c.Boolean(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeeDues", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.EmployeeDues", new[] { "EmployeeId" });
            DropTable("dbo.EmployeeDues");
        }
    }
}
