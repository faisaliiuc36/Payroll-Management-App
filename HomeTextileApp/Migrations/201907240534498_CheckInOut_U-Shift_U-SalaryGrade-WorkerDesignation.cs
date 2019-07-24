namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CheckInOut_UShift_USalaryGradeWorkerDesignation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WorkerDesignations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SalaryGradeId = c.Int(),
                        Name = c.String(),
                        EffectiveDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SalaryGrades", t => t.SalaryGradeId)
                .Index(t => t.SalaryGradeId);
            
            CreateTable(
                "dbo.SalaryGrades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Employees", "WorkerDesignationId", c => c.Int());
            AddColumn("dbo.Shifts", "IsGeneral", c => c.Boolean(nullable: false));
            AddColumn("dbo.Shifts", "IsDayToNight", c => c.Boolean(nullable: false));
            AddColumn("dbo.Shifts", "EffectiveDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Emp_CheckInOut", "IsManual", c => c.Boolean(nullable: false));
            AddColumn("dbo.Emp_CheckInOut", "UpdatedBy", c => c.String());
            AddColumn("dbo.Salaries", "TechnicalAllowance", c => c.Double(nullable: false));
            AddColumn("dbo.SalarySettings", "Date", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Employees", "WorkerDesignationId");
            AddForeignKey("dbo.Employees", "WorkerDesignationId", "dbo.WorkerDesignations", "Id");
            DropColumn("dbo.Salaries", "Extra");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Salaries", "Extra", c => c.Double(nullable: false));
            DropForeignKey("dbo.Employees", "WorkerDesignationId", "dbo.WorkerDesignations");
            DropForeignKey("dbo.WorkerDesignations", "SalaryGradeId", "dbo.SalaryGrades");
            DropIndex("dbo.WorkerDesignations", new[] { "SalaryGradeId" });
            DropIndex("dbo.Employees", new[] { "WorkerDesignationId" });
            DropColumn("dbo.SalarySettings", "Date");
            DropColumn("dbo.Salaries", "TechnicalAllowance");
            DropColumn("dbo.Emp_CheckInOut", "UpdatedBy");
            DropColumn("dbo.Emp_CheckInOut", "IsManual");
            DropColumn("dbo.Shifts", "EffectiveDate");
            DropColumn("dbo.Shifts", "IsDayToNight");
            DropColumn("dbo.Shifts", "IsGeneral");
            DropColumn("dbo.Employees", "WorkerDesignationId");
            DropTable("dbo.SalaryGrades");
            DropTable("dbo.WorkerDesignations");
        }
    }
}
