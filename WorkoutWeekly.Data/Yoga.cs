using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutWeekly.Data
{
    public class Yoga
    {
        [Key]
        public int YogaWorkoutId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public string YogaWorkoutTitle { get; set; }

        [Required]
        public string YogaWorkout { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
