namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NationalIdNotUnique : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employees", new[] { "NationalId" });
            AlterColumn("dbo.Employees", "NationalId", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "NationalId", c => c.String(maxLength: 450));
            CreateIndex("dbo.Employees", "NationalId", unique: true);
        }
    }
}
