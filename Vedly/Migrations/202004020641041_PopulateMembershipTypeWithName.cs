namespace Vedly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypeWithName : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM MembershipTypes");
            Sql("INSERT INTO MembershipTypes (Id,Name,SignUpFee,DurationInMonths,DiscountRate) VALUES (1,'Pay As You Go', 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id,Name,SignUpFee,DurationInMonths,DiscountRate) VALUES (2,'Monthly', 30, 1, 10)");
            Sql("INSERT INTO MembershipTypes (Id,Name,SignUpFee,DurationInMonths,DiscountRate) VALUES (3,'Monthly', 90, 3, 15)");
            Sql("INSERT INTO MembershipTypes (Id,Name,SignUpFee,DurationInMonths,DiscountRate) VALUES (4,'Monthly', 300, 12, 20)");

        }

        public override void Down()
        {
        }
    }
}
