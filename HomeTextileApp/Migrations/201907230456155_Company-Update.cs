namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompanyUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            AddColumn("dbo.Units", "CompanyId", c => c.Int());
            CreateIndex("dbo.Units", "CompanyId");
            AddForeignKey("dbo.Units", "CompanyId", "dbo.Companies", "Id");
            DropColumn("dbo.Employees", "CompanyId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "CompanyId", c => c.Int());
            DropForeignKey("dbo.Units", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Units", new[] { "CompanyId" });
            DropColumn("dbo.Units", "CompanyId");
            CreateIndex("dbo.Employees", "CompanyId");
            AddForeignKey("dbo.Employees", "CompanyId", "dbo.Companies", "Id");
        }
    }
}
