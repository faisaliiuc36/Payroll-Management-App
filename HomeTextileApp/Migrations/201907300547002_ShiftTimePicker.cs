namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShiftTimePicker : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Shifts", "From", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Shifts", "To", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Shifts", "To", c => c.String(nullable: false));
            AlterColumn("dbo.Shifts", "From", c => c.String(nullable: false));
        }
    }
}
