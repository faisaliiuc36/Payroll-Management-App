namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Admin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HTAdmins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Admin = c.Boolean(nullable: false),
                        Attendance = c.Boolean(nullable: false),
                        SearchAttendance = c.Boolean(nullable: false),
                        Manual = c.Boolean(nullable: false),
                        Setting = c.Boolean(nullable: false),
                        Leave = c.Boolean(nullable: false),
                        Import = c.Boolean(nullable: false),
                        Employee = c.Boolean(nullable: false),
                        Loan = c.Boolean(nullable: false),
                        Holiday = c.Boolean(nullable: false),
                        DutyRoster = c.Boolean(nullable: false),
                        Shift = c.Boolean(nullable: false),
                        Salary = c.Boolean(nullable: false),
                        Bonus = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.HTAdmins");
        }
    }
}
