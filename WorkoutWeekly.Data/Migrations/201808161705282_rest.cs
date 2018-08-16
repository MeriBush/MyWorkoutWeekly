namespace WorkoutWeekly.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rest : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Workouts", newName: "Workout");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Workout", newName: "Workouts");
        }
    }
}
