namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Type", c => c.String());
            Sql("UPDATE MembershipTypes SET Type = 'Pay As You Go' WHERE Id = 1");
            Sql("UPDATE MembershipTypes SET Type = 'Monthly' WHERE Id = 2");
            Sql("UPDATE MembershipTypes SET Type = 'Quarterly Three Months' WHERE Id = 3");
            Sql("UPDATE MembershipTypes SET Type = 'Annual' WHERE Id = 4");
        }
        
        public override void Down()
        {
            DropColumn("dbo.MembershipTypes", "Type");
        }
    }
}
