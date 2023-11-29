namespace Sport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameOfYourMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainer", "FirstNamee", c => c.String());
            DropColumn("dbo.Trainer", "FirstName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Trainer", "FirstName", c => c.String());
            DropColumn("dbo.Trainer", "FirstNamee");
        }
    }
}
