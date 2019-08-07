namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emp_CheckInOutUpdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emp_CheckInOut", "IsAbsent", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emp_CheckInOut", "IsAbsent");
        }
    }
}
