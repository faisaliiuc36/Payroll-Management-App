namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdvanceBonus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Advances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        Installment = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            AddColumn("dbo.Paytimes", "Advance_Id", c => c.Int());
            AddColumn("dbo.Bonus", "Reason", c => c.String(nullable: false));
            CreateIndex("dbo.Paytimes", "Advance_Id");
            AddForeignKey("dbo.Paytimes", "Advance_Id", "dbo.Advances", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paytimes", "Advance_Id", "dbo.Advances");
            DropForeignKey("dbo.Advances", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Paytimes", new[] { "Advance_Id" });
            DropIndex("dbo.Advances", new[] { "EmployeeId" });
            DropColumn("dbo.Bonus", "Reason");
            DropColumn("dbo.Paytimes", "Advance_Id");
            DropTable("dbo.Advances");
        }
    }
}
