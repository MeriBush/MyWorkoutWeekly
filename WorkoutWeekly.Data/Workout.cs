using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutWeekly.Data
{
    public enum WorkoutEnum
    {
        Pilates, Jogging, Yoga, HIIT, Rest
    }

    public class Workout
    {
        [Key]
        public int WorkoutId { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public WorkoutEnum WorkoutType { get; set; }

        [Required]
        public string WorkoutTitle { get; set; }

        [Required]
        public string WorkoutDetails { get; set; }

        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
