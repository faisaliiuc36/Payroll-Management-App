namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpInActiveLoanUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.InActiveHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            AddColumn("dbo.Employees", "IsWorker", c => c.String());
            AddColumn("dbo.Employees", "Password", c => c.String());
            AddColumn("dbo.Loans", "Installment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.InActiveHistories", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.InActiveHistories", new[] { "EmployeeId" });
            DropColumn("dbo.Loans", "Installment");
            DropColumn("dbo.Employees", "Password");
            DropColumn("dbo.Employees", "IsWorker");
            DropTable("dbo.InActiveHistories");
        }
    }
}
