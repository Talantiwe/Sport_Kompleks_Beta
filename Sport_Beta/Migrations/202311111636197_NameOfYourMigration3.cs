namespace Sport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameOfYourMigration3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainer", "Photo", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainer", "Photo");
        }
    }
}
