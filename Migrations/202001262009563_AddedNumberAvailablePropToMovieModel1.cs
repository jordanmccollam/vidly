namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedNumberAvailablePropToMovieModel1 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET NumberAvailable = Stock");
        }
        
        public override void Down()
        {
        }
    }
}
