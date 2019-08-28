namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HTAdmins", "Settings", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "LeaveAndHoliday", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Report", c => c.Boolean(nullable: false));
            DropColumn("dbo.HTAdmins", "SearchAttendance");
            DropColumn("dbo.HTAdmins", "Manual");
            DropColumn("dbo.HTAdmins", "Setting");
            DropColumn("dbo.HTAdmins", "Leave");
            DropColumn("dbo.HTAdmins", "Import");
            DropColumn("dbo.HTAdmins", "Loan");
            DropColumn("dbo.HTAdmins", "Holiday");
            DropColumn("dbo.HTAdmins", "DutyRoster");
            DropColumn("dbo.HTAdmins", "Shift");
            DropColumn("dbo.HTAdmins", "Salary");
            DropColumn("dbo.HTAdmins", "Bonus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.HTAdmins", "Bonus", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Salary", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Shift", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "DutyRoster", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Holiday", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Loan", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Import", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Leave", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Setting", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "Manual", c => c.Boolean(nullable: false));
            AddColumn("dbo.HTAdmins", "SearchAttendance", c => c.Boolean(nullable: false));
            DropColumn("dbo.HTAdmins", "Report");
            DropColumn("dbo.HTAdmins", "LeaveAndHoliday");
            DropColumn("dbo.HTAdmins", "Settings");
        }
    }
}
