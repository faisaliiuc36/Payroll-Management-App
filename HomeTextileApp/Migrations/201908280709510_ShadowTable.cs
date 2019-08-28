namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShadowTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ShadowEmployees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoWId = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Emp_Id = c.Int(nullable: false),
                        EmployeeTypeId = c.Int(),
                        HTAdminId = c.Int(),
                        SectionId = c.Int(),
                        EmpFullName = c.String(),
                        BadgeNumber = c.String(),
                        DateOfBirth = c.DateTime(),
                        NationalId = c.String(),
                        BloodGroupId = c.Int(),
                        HireDate = c.DateTime(),
                        ReligionId = c.Int(),
                        MaritialStatusId = c.Int(),
                        IsWorker = c.Boolean(nullable: false),
                        Address = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                        ActiveStatus = c.Boolean(nullable: false),
                        DesignationId = c.Int(),
                        WorkerDesignationId = c.Int(),
                        TechnicalAllowance = c.Double(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        MiddleName = c.String(),
                        EmergencyContact = c.String(),
                        GenderId = c.Int(),
                        IsTrainee = c.Boolean(nullable: false),
                        Permanent = c.DateTime(),
                        EndDate = c.DateTime(),
                        InsertDate = c.DateTime(),
                        ImagePath = c.String(),
                        ImageFile = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BloodGroups", t => t.BloodGroupId)
                .ForeignKey("dbo.Designations", t => t.DesignationId)
                .ForeignKey("dbo.EmployeeTypes", t => t.EmployeeTypeId)
                .ForeignKey("dbo.Genders", t => t.GenderId)
                .ForeignKey("dbo.HTAdmins", t => t.HTAdminId)
                .ForeignKey("dbo.MaritialStatus", t => t.MaritialStatusId)
                .ForeignKey("dbo.Religions", t => t.ReligionId)
                .ForeignKey("dbo.Sections", t => t.SectionId)
                .ForeignKey("dbo.WorkerDesignations", t => t.WorkerDesignationId)
                .Index(t => t.EmployeeTypeId)
                .Index(t => t.HTAdminId)
                .Index(t => t.SectionId)
                .Index(t => t.BloodGroupId)
                .Index(t => t.ReligionId)
                .Index(t => t.MaritialStatusId)
                .Index(t => t.DesignationId)
                .Index(t => t.WorkerDesignationId)
                .Index(t => t.GenderId);
            
            CreateTable(
                "dbo.ShadowSalaryGrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoWId = c.Int(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        HTAdminId = c.Int(),
                        GradeId = c.Int(nullable: false),
                        GradeName = c.String(),
                        Description = c.String(),
                        Salary = c.Single(nullable: false),
                        YearlyIncrement = c.Single(nullable: false),
                        HouseRent = c.Single(nullable: false),
                        MedicalAllowance = c.Single(nullable: false),
                        TransportAllowance = c.Single(nullable: false),
                        FoodAllowance = c.Single(nullable: false),
                        Total = c.Single(nullable: false),
                        EffectiveFrom = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HTAdmins", t => t.HTAdminId)
                .Index(t => t.HTAdminId);
            
            AddColumn("dbo.Duty_Roster", "ShadowEmployee_Id", c => c.Int());
            AddColumn("dbo.InActiveHistories", "ShadowEmployee_Id", c => c.Int());
            AddColumn("dbo.Loans", "ShadowEmployee_Id", c => c.Int());
            CreateIndex("dbo.Duty_Roster", "ShadowEmployee_Id");
            CreateIndex("dbo.InActiveHistories", "ShadowEmployee_Id");
            CreateIndex("dbo.Loans", "ShadowEmployee_Id");
            AddForeignKey("dbo.Duty_Roster", "ShadowEmployee_Id", "dbo.ShadowEmployees", "Id");
            AddForeignKey("dbo.InActiveHistories", "ShadowEmployee_Id", "dbo.ShadowEmployees", "Id");
            AddForeignKey("dbo.Loans", "ShadowEmployee_Id", "dbo.ShadowEmployees", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShadowSalaryGrades", "HTAdminId", "dbo.HTAdmins");
            DropForeignKey("dbo.ShadowEmployees", "WorkerDesignationId", "dbo.WorkerDesignations");
            DropForeignKey("dbo.ShadowEmployees", "SectionId", "dbo.Sections");
            DropForeignKey("dbo.ShadowEmployees", "ReligionId", "dbo.Religions");
            DropForeignKey("dbo.ShadowEmployees", "MaritialStatusId", "dbo.MaritialStatus");
            DropForeignKey("dbo.Loans", "ShadowEmployee_Id", "dbo.ShadowEmployees");
            DropForeignKey("dbo.InActiveHistories", "ShadowEmployee_Id", "dbo.ShadowEmployees");
            DropForeignKey("dbo.ShadowEmployees", "HTAdminId", "dbo.HTAdmins");
            DropForeignKey("dbo.ShadowEmployees", "GenderId", "dbo.Genders");
            DropForeignKey("dbo.ShadowEmployees", "EmployeeTypeId", "dbo.EmployeeTypes");
            DropForeignKey("dbo.Duty_Roster", "ShadowEmployee_Id", "dbo.ShadowEmployees");
            DropForeignKey("dbo.ShadowEmployees", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.ShadowEmployees", "BloodGroupId", "dbo.BloodGroups");
            DropIndex("dbo.ShadowSalaryGrades", new[] { "HTAdminId" });
            DropIndex("dbo.ShadowEmployees", new[] { "GenderId" });
            DropIndex("dbo.ShadowEmployees", new[] { "WorkerDesignationId" });
            DropIndex("dbo.ShadowEmployees", new[] { "DesignationId" });
            DropIndex("dbo.ShadowEmployees", new[] { "MaritialStatusId" });
            DropIndex("dbo.ShadowEmployees", new[] { "ReligionId" });
            DropIndex("dbo.ShadowEmployees", new[] { "BloodGroupId" });
            DropIndex("dbo.ShadowEmployees", new[] { "SectionId" });
            DropIndex("dbo.ShadowEmployees", new[] { "HTAdminId" });
            DropIndex("dbo.ShadowEmployees", new[] { "EmployeeTypeId" });
            DropIndex("dbo.Loans", new[] { "ShadowEmployee_Id" });
            DropIndex("dbo.InActiveHistories", new[] { "ShadowEmployee_Id" });
            DropIndex("dbo.Duty_Roster", new[] { "ShadowEmployee_Id" });
            DropColumn("dbo.Loans", "ShadowEmployee_Id");
            DropColumn("dbo.InActiveHistories", "ShadowEmployee_Id");
            DropColumn("dbo.Duty_Roster", "ShadowEmployee_Id");
            DropTable("dbo.ShadowSalaryGrades");
            DropTable("dbo.ShadowEmployees");
        }
    }
}
