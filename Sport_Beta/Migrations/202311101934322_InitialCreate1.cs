namespace Sport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class RenameTrainersToTrainer : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Trainer", newName: "Trainer");
        }

        public override void Down()
        {
            RenameTable(name: "dbo.Traine", newName: "Trainers");
        }
    }
}
