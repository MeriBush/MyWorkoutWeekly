using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutWeekly.Data
{
    public enum DaysOfWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    }

    public class Schedule
    {
        [Key]
        public int ScheduleID { get; set; }

        [Required]
        public DaysOfWeek Day { get; set; }
    }
}
