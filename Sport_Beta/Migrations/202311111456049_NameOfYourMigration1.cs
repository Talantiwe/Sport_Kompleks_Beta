namespace Sport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameOfYourMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainer", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainer", "LastName");
        }
    }
}
