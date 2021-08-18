namespace RentalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatemembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) Values (1, 0, 0, 0)");
            Sql("Insert into MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) Values (2, 30, 2, 40)");
            Sql("Insert into MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) Values (3, 45, 1, 10)");
            Sql("Insert into MembershipTypes (Id, SignUpFee, DurationInMonth, DiscountRate) Values (4, 23, 2, 22)");
        }
        
        public override void Down()
        {
        }
    }
}
