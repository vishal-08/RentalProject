﻿namespace RentalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeName : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET Name = 'Pay As You Go' WHERE Id = 1; ");
            Sql("UPDATE MembershipTypes SET Name = 'Monthly' WHERE Id = 2; ");
            Sql("UPDATE MembershipTypes SET Name = 'Quaterly' WHERE Id = 3; ");
            Sql("UPDATE MembershipTypes SET Name = 'Yearly' WHERE Id = 4; ");
        }
        
        public override void Down()
        {
        }
    }
}
