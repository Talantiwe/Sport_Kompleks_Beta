namespace Sport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainer", "FirstName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainer", "FirstName");
        }
    }
}
