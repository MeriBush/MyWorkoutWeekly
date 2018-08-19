using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutWeekly.Data;
using WorkoutWeekly.Models;

namespace WorkoutWeekly.Services
{
    public class WorkoutService
    {
        private readonly Guid _userId;

        public WorkoutService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateWorkout (WorkoutCreate model)
        {
            var entity =
                new Workout()
                {
                    UserId = _userId,
                    WorkoutTitle = model.WorkoutTitle,
                    WorkoutType = model.WorkoutType,
                    WorkoutDetails = model.WorkoutDetails,
                    CreatedUtc = DateTimeOffset.Now,

                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Workout.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<WorkoutListItem> GetWorkouts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Workout
                        .Where(e => e.UserId == _userId)
                        .Select(
                            e =>
                                new WorkoutListItem
                                {
                                    WorkoutId = e.WorkoutId,
                                    WorkoutTitle = e.WorkoutTitle,
                                    WorkoutType = e.WorkoutType,
                                    WorkoutDetails =e.WorkoutDetails,
                                    CreatedUtc = e.CreatedUtc
                                });
                return query.ToArray();
            }
        }
    }
}
