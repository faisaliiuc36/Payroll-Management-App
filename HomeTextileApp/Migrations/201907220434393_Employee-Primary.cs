namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeePrimary : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BloodGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Emp_Id = c.Int(nullable: false),
                        EmployeeTypeId = c.Int(),
                        CompanyId = c.Int(),
                        SectionId = c.Int(),
                        EmpFullName = c.String(),
                        BadgeNumber = c.String(),
                        DateOfBirth = c.DateTime(),
                        BloodGroupId = c.Int(),
                        HireDate = c.DateTime(),
                        ReligionId = c.Int(),
                        MaritialStatusId = c.Int(),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        ActiveStatus = c.Boolean(nullable: false),
                        IsEdited = c.Boolean(nullable: false),
                        DesignationId = c.Int(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        EmergencyContact = c.String(),
                        GenderId = c.Int(),
                        IsTrainee = c.Boolean(nullable: false),
                        EndDate = c.DateTime(),
                        InsertDate = c.DateTime(),
                        ImagePath = c.String(),
                        ImageFile = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BloodGroups", t => t.BloodGroupId)
                .ForeignKey("dbo.Companies", t => t.CompanyId)
                .ForeignKey("dbo.Designations", t => t.DesignationId)
                .ForeignKey("dbo.EmployeeTypes", t => t.EmployeeTypeId)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .ForeignKey("dbo.MaritialStatus", t => t.MaritialStatusId)
                .ForeignKey("dbo.Religions", t => t.ReligionId)
                .ForeignKey("dbo.Sections", t => t.SectionId)
                .Index(t => t.EmployeeTypeId)
                .Index(t => t.CompanyId)
                .Index(t => t.SectionId)
                .Index(t => t.BloodGroupId)
                .Index(t => t.ReligionId)
                .Index(t => t.MaritialStatusId)
                .Index(t => t.DesignationId)
                .Index(t => t.GenderId);
            
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Designations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Duty_Roster",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        ShiftId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.Shifts", t => t.ShiftId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.ShiftId);
            
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        From = c.String(nullable: false),
                        To = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EmployeeTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Holidays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        LeaveTypeId = c.Int(nullable: false),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.LeaveTypes", t => t.LeaveTypeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.LeaveTypeId);
            
            CreateTable(
                "dbo.LeaveTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Tags = c.String(nullable: false),
                        Count = c.Int(nullable: false),
                        Paid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LeaveStores",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        LeaveTypeId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Spent = c.Int(nullable: false),
                        LeaveId = c.Int(nullable: false),
                        IsManual = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .ForeignKey("dbo.LeaveTypes", t => t.LeaveTypeId, cascadeDelete: true)
                .Index(t => t.EmployeeId)
                .Index(t => t.LeaveTypeId);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Paytimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LoanId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Paid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Loans", t => t.LoanId, cascadeDelete: true)
                .Index(t => t.LoanId);
            
            CreateTable(
                "dbo.MaritialStatus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Religions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sections",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepartmentId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DepartmentId, cascadeDelete: true)
                .Index(t => t.DepartmentId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitId = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId);
            
            CreateTable(
                "dbo.Units",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emp_CheckInOut",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        CHECKTIME = c.DateTime(nullable: false),
                        LOGID = c.Int(nullable: false),
                        MACHINEID = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Salaries",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        Extra = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.SalarySettings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.Int(nullable: false),
                        Basic = c.Double(nullable: false),
                        HouseRent = c.Double(nullable: false),
                        convenience = c.Double(nullable: false),
                        Medical = c.Double(nullable: false),
                        Stamp = c.Double(nullable: false),
                        Tax = c.Double(nullable: false),
                        Others = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Salaries", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.Departments", "UnitId", "dbo.Units");
            DropForeignKey("dbo.Sections", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Employees", "ReligionId", "dbo.Religions");
            DropForeignKey("dbo.Employees", "MaritialStatusId", "dbo.MaritialStatus");
            DropForeignKey("dbo.Paytimes", "LoanId", "dbo.Loans");
            DropForeignKey("dbo.Loans", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.LeaveStores", "LeaveTypeId", "dbo.LeaveTypes");
            DropForeignKey("dbo.LeaveStores", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Leaves", "LeaveTypeId", "dbo.LeaveTypes");
            DropForeignKey("dbo.Leaves", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Holidays", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.Employees", "EmployeeTypeId", "dbo.EmployeeTypes");
            DropForeignKey("dbo.Duty_Roster", "ShiftId", "dbo.Shifts");
            DropForeignKey("dbo.Duty_Roster", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Employees", "CompanyId", "dbo.Companies");
            DropForeignKey("dbo.Employees", "BloodGroupId", "dbo.BloodGroups");
            DropIndex("dbo.Salaries", new[] { "EmployeeId" });
            DropIndex("dbo.Departments", new[] { "UnitId" });
            DropIndex("dbo.Sections", new[] { "DepartmentId" });
            DropIndex("dbo.Paytimes", new[] { "LoanId" });
            DropIndex("dbo.Loans", new[] { "EmployeeId" });
            DropIndex("dbo.LeaveStores", new[] { "LeaveTypeId" });
            DropIndex("dbo.LeaveStores", new[] { "EmployeeId" });
            DropIndex("dbo.Leaves", new[] { "LeaveTypeId" });
            DropIndex("dbo.Leaves", new[] { "EmployeeId" });
            DropIndex("dbo.Holidays", new[] { "EmployeeId" });
            DropIndex("dbo.Duty_Roster", new[] { "ShiftId" });
            DropIndex("dbo.Duty_Roster", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "GenderId" });
            DropIndex("dbo.Employees", new[] { "DesignationId" });
            DropIndex("dbo.Employees", new[] { "MaritialStatusId" });
            DropIndex("dbo.Employees", new[] { "ReligionId" });
            DropIndex("dbo.Employees", new[] { "BloodGroupId" });
            DropIndex("dbo.Employees", new[] { "SectionId" });
            DropIndex("dbo.Employees", new[] { "CompanyId" });
            DropIndex("dbo.Employees", new[] { "EmployeeTypeId" });
            DropTable("dbo.SalarySettings");
            DropTable("dbo.Salaries");
            DropTable("dbo.Emp_CheckInOut");
            DropTable("dbo.Units");
            DropTable("dbo.Departments");
            DropTable("dbo.Sections");
            DropTable("dbo.Religions");
            DropTable("dbo.MaritialStatus");
            DropTable("dbo.Paytimes");
            DropTable("dbo.Loans");
            DropTable("dbo.LeaveStores");
            DropTable("dbo.LeaveTypes");
            DropTable("dbo.Leaves");
            DropTable("dbo.Holidays");
            DropTable("dbo.Genders");
            DropTable("dbo.EmployeeTypes");
            DropTable("dbo.Shifts");
            DropTable("dbo.Duty_Roster");
            DropTable("dbo.Designations");
            DropTable("dbo.Companies");
            DropTable("dbo.Employees");
            DropTable("dbo.BloodGroups");
        }
    }
}
