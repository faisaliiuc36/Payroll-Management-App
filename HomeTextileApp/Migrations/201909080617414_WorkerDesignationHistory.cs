namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WorkerDesignationHistory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "WorkerDesignationId", "dbo.WorkerDesignations");
            DropIndex("dbo.Employees", new[] { "WorkerDesignationId" });
            CreateTable(
                "dbo.WorkerDesignationHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        WorkerDesignationId = c.Int(),
                        TechnicalAllowance = c.Double(nullable: false),
                        From = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.WorkerDesignations", t => t.WorkerDesignationId)
                .Index(t => t.EmployeeId)
                .Index(t => t.WorkerDesignationId);
            
            DropColumn("dbo.Employees", "WorkerDesignationId");
            DropColumn("dbo.Employees", "TechnicalAllowance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "TechnicalAllowance", c => c.Double(nullable: false));
            AddColumn("dbo.Employees", "WorkerDesignationId", c => c.Int());
            DropForeignKey("dbo.WorkerDesignationHistories", "WorkerDesignationId", "dbo.WorkerDesignations");
            DropForeignKey("dbo.WorkerDesignationHistories", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.WorkerDesignationHistories", new[] { "WorkerDesignationId" });
            DropIndex("dbo.WorkerDesignationHistories", new[] { "EmployeeId" });
            DropTable("dbo.WorkerDesignationHistories");
            CreateIndex("dbo.Employees", "WorkerDesignationId");
            AddForeignKey("dbo.Employees", "WorkerDesignationId", "dbo.WorkerDesignations", "Id");
        }
    }
}
