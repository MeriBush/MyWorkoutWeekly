using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkoutWeekly.Data;

namespace WorkoutWeekly.Models
{
    public class WorkoutListItem
    {
        [Display(Name ="Workout ID")]
        public int WorkoutId { get; set; }

        [Display(Name="Title")]
        public string WorkoutTitle { get; set; }

        [Display(Name ="Type")]
        public WorkoutEnum WorkoutType { get; set; }
        
        [Display(Name ="Details")]
        public string WorkoutDetails { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => WorkoutTitle;
    }
}
