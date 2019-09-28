namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SalaryGradeU : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.SalaryGrades", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SalaryGrades", "Total", c => c.Single(nullable: false));
        }
    }
}
