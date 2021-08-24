namespace RentalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BirthDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "BirthDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "BirthDate");
        }
    }
}
