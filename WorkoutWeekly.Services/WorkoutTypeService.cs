using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutWeekly.Data;
using WorkoutWeekly.Models;

namespace WorkoutWeekly.Services
{
    public class WorkoutTypeService
    {
        private readonly Guid _userId;

        public WorkoutTypeService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateWorkoutType(WorkoutTypeCreate model)
        {
            var entity =
                new WorkoutType()
                {
                    UserId = _userId,
                    Type = model.Type,
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.WorkoutType.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<WorkoutTypeListItem> GetWorkoutTypes()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .WorkoutType
                    .Where(e => e.UserId == _userId)
                    .Select(
                        e =>
                        new WorkoutTypeListItem
                        {
                            WorkoutTypeId = e.WorkoutTypeId,
                            Type = e.Type
                        });

                return query.ToArray();
            }
        }

        public WorkoutTypeDetail GetWorkoutTypeById(int workoutTypeId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .WorkoutType
                    .Single(e => e.WorkoutTypeId == workoutTypeId && e.UserId == _userId);
                return
                    new WorkoutTypeDetail
                    {
                        WorkoutTypeId = entity.WorkoutTypeId,
                        Type = entity.Type,
                        CreatedUtc = entity.CreatedUtc,
                        ModifiedUtc = entity.ModifiedUtc
                    };
            }
        }

        public bool UpdateWorkoutType(WorkoutTypeEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .WorkoutType
                    .Single(e => e.WorkoutTypeId == model.WorkoutTypeId && e.UserId == model._userId);

                entity.Type = model.Type;
                entity.ModifiedUtc = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
