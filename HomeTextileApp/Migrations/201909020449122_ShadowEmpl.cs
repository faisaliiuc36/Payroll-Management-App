namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShadowEmpl : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Duty_Roster", "ShadowEmployee_Id", "dbo.ShadowEmployees");
            DropForeignKey("dbo.InActiveHistories", "ShadowEmployee_Id", "dbo.ShadowEmployees");
            DropForeignKey("dbo.Loans", "ShadowEmployee_Id", "dbo.ShadowEmployees");
            DropIndex("dbo.Duty_Roster", new[] { "ShadowEmployee_Id" });
            DropIndex("dbo.InActiveHistories", new[] { "ShadowEmployee_Id" });
            DropIndex("dbo.Loans", new[] { "ShadowEmployee_Id" });
            DropColumn("dbo.Duty_Roster", "ShadowEmployee_Id");
            DropColumn("dbo.InActiveHistories", "ShadowEmployee_Id");
            DropColumn("dbo.Loans", "ShadowEmployee_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Loans", "ShadowEmployee_Id", c => c.Int());
            AddColumn("dbo.InActiveHistories", "ShadowEmployee_Id", c => c.Int());
            AddColumn("dbo.Duty_Roster", "ShadowEmployee_Id", c => c.Int());
            CreateIndex("dbo.Loans", "ShadowEmployee_Id");
            CreateIndex("dbo.InActiveHistories", "ShadowEmployee_Id");
            CreateIndex("dbo.Duty_Roster", "ShadowEmployee_Id");
            AddForeignKey("dbo.Loans", "ShadowEmployee_Id", "dbo.ShadowEmployees", "Id");
            AddForeignKey("dbo.InActiveHistories", "ShadowEmployee_Id", "dbo.ShadowEmployees", "Id");
            AddForeignKey("dbo.Duty_Roster", "ShadowEmployee_Id", "dbo.ShadowEmployees", "Id");
        }
    }
}
