namespace WorkoutWeekly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Workouts", "WorkoutDetails", c => c.String(nullable: false));
            DropColumn("dbo.Workouts", "Workout");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Workouts", "Workout", c => c.String(nullable: false));
            DropColumn("dbo.Workouts", "WorkoutDetails");
        }
    }
}
