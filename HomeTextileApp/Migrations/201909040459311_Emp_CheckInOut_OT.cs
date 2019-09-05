namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Emp_CheckInOut_OT : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emp_CheckInOut", "OT", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emp_CheckInOut", "OT");
        }
    }
}
