namespace WorkoutWeekly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Schedule", "UserId", c => c.Guid(nullable: false));
            AddColumn("dbo.WorkoutType", "UserId", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkoutType", "UserId");
            DropColumn("dbo.Schedule", "UserId");
        }
    }
}
