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
    }
}
