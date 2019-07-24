namespace HomeTextileApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmpAddPermanentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Permanent", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Permanent");
        }
    }
}
