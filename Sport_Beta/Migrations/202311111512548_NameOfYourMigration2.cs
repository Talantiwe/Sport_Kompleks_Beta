namespace Sport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameOfYourMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Trainer", "Age", c => c.String());
            AddColumn("dbo.Trainer", "History", c => c.String());
            AddColumn("dbo.Trainer", "Expirience", c => c.String());
            AddColumn("dbo.Trainer", "Education", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Trainer", "Education");
            DropColumn("dbo.Trainer", "Expirience");
            DropColumn("dbo.Trainer", "History");
            DropColumn("dbo.Trainer", "Age");
        }
    }
}
