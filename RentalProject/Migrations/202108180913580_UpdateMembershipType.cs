namespace RentalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Discountrate = 10  WHERE Id = 2; ");
            Sql("UPDATE MembershipTypes SET SignUpFee = 90, DurationInMonth = 6 , Discountrate = 15  WHERE Id = 3; ");
            Sql("UPDATE MembershipTypes SET SignUpFee = 120, DurationInMonth = 12 , Discountrate = 15  WHERE Id = 4; ");
        }
        
        public override void Down()
        {
        }
    }
}
