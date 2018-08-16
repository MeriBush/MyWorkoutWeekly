using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutWeekly.Data;

namespace WorkoutWeekly.Models
{
    public class WorkoutCreate
    {
        [Required]
        [Display(Name ="Workout Type")]
        public WorkoutEnum WorkoutType { get; set; }

        [Required]
        [Display(Name ="Workout Title")]
        public string WorkoutTitle { get; set; }

        [Required]
        [Display(Name ="Workout Details")]
        public string WorkoutDetails { get; set; }

        public override string ToString() => WorkoutTitle;
    }
}
