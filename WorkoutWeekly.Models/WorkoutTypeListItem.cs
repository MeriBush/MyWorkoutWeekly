using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutWeekly.Models
{
    public class WorkoutTypeListItem
    {
        [Display(Name ="Exercise ID")]
        public int WorkoutTypeId { get; set; }

        [Display(Name ="Exercise Type")]
        public string Type { get; set; }

        [Display(Name="Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
